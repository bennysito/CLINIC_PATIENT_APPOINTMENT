using System;
using System.Linq;
using System.Windows.Forms;

namespace JAMES_CODEV2
{
    public partial class Form1 : Form
    {
        private DataClasses1DataContext db;

        public Form1()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();

            cmbPatSex.SelectedIndex = 0;
            cmbPatStatus.SelectedIndex = 0;
            cmbInvPayStatus.SelectedIndex = 0;

            LoadAllData();
        }

        #region PATIENTS LOGIC
        private void LoadPatients()
        {
            try
            {
                db = new DataClasses1DataContext();

                var patients = db.usp_Patient_CRUD(
                    "GETALL", null, null, null, null, null, null, null
                ).OrderBy(p => p.patientId).ToList();

                if (!chkShowInactivePatients.Checked)
                {
                    patients = patients.Where(p => p.patientStatus == "Active").ToList();
                }

                dgvPatients.DataSource = patients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkShowInactivePatients_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatSearch.Text))
            {
                LoadPatients();
            }
            else
            {
                SearchPatients();
            }
        }

        private void BtnPatSearch_Click(object sender, EventArgs e)
        {
            SearchPatients();
        }

        private void SearchPatients()
        {
            if (string.IsNullOrWhiteSpace(txtPatSearch.Text))
            {
                LoadPatients();
                return;
            }

            try
            {
                var results = db.usp_Patient_Search(txtPatSearch.Text.Trim())
                                .OrderBy(p => p.patientId)
                                .ToList();

                if (!chkShowInactivePatients.Checked)
                {
                    results = results.Where(p => p.patientStatus == "Active").ToList();
                }

                dgvPatients.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPatResetSearch_Click(object sender, EventArgs e)
        {
            txtPatSearch.Clear();
            LoadPatients();
        }

        private void BtnPatInsert_Click(object sender, EventArgs e)
        {
            if (!ValidatePatientInput(out int pNo)) return;

            try
            {
                db.usp_Patient_CRUD(
                    "INSERT",
                    null,
                    pNo,
                    txtPatName.Text.Trim(),
                    dtpPatBirth.Value.Date,
                    cmbPatSex.SelectedItem.ToString(),
                    txtPatContact.Text.Trim(),
                    cmbPatStatus.SelectedItem.ToString()
                );

                MessageBox.Show("Patient added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearPatientFields();
                LoadPatients();
                PopulateAppointmentDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Failed: " + ex.Message,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnPatUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatId.Text))
            {
                MessageBox.Show("Select a patient from the table first.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatePatientInput(out int pNo)) return;

            try
            {
                int pId = int.Parse(txtPatId.Text);
                string newStatus = cmbPatStatus.SelectedItem.ToString();

                db.usp_Patient_CRUD(
                    "UPDATE",
                    pId,
                    pNo,
                    txtPatName.Text.Trim(),
                    dtpPatBirth.Value.Date,
                    cmbPatSex.SelectedItem.ToString(),
                    txtPatContact.Text.Trim(),
                    newStatus
                );

                MessageBox.Show(
                    $"Patient record updated successfully (Status: {newStatus})!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                ClearPatientFields();
                LoadPatients();
                PopulateAppointmentDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPatClear_Click(object sender, EventArgs e)
        {
            ClearPatientFields();
        }

        private bool ValidatePatientInput(out int pNo)
        {
            pNo = 0;

            if (!int.TryParse(txtPatNo.Text.Trim(), out pNo))
            {
                MessageBox.Show("Patient Number must be a valid integer.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPatName.Text))
            {
                MessageBox.Show("Patient Full Name is required.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPatContact.Text.Trim().Length != 11)
            {
                MessageBox.Show("Contact Number must be exactly 11 digits per database constraint.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearPatientFields()
        {
            txtPatId.Clear();
            txtPatNo.Clear();
            txtPatName.Clear();
            txtPatContact.Clear();
            dtpPatBirth.Value = DateTime.Today;
            cmbPatSex.SelectedIndex = 0;
            cmbPatStatus.SelectedIndex = 0;
        }

        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPatients.Rows[e.RowIndex].Cells["patientId"].Value != null)
            {
                DataGridViewRow r = dgvPatients.Rows[e.RowIndex];

                txtPatId.Text = r.Cells["patientId"].Value.ToString();
                txtPatNo.Text = r.Cells["patientNo"].Value.ToString();
                txtPatName.Text = r.Cells["fullName"].Value.ToString();
                dtpPatBirth.Value = Convert.ToDateTime(r.Cells["birthDate"].Value);
                cmbPatSex.SelectedItem = r.Cells["sex"].Value.ToString();
                txtPatContact.Text = r.Cells["contactNumber"].Value.ToString();
                cmbPatStatus.SelectedItem = r.Cells["patientStatus"].Value.ToString();
            }
        }
        #endregion

        #region DOCTORS LOGIC
        private void LoadDoctors()
        {
            try
            {
                db = new DataClasses1DataContext();

                var doctors = db.usp_Doctor_GetAll()
                                .OrderBy(d => d.doctorId)
                                .ToList();

                if (!chkShowInactiveDoctors.Checked)
                {
                    doctors = doctors.Where(d => !d.specialization.Contains("(Inactive)")).ToList();
                }

                dgvDoctors.DataSource = doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkShowInactiveDoctors_CheckedChanged(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void BtnDocInsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDocLicense.Text.Trim(), out int lic))
            {
                MessageBox.Show("License No must be a valid integer.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDocName.Text) ||
                string.IsNullOrWhiteSpace(txtDocSpec.Text))
            {
                MessageBox.Show("Name and Specialization are required.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.usp_Doctor_CRUD(
                    "INSERT", null, lic,
                    txtDocName.Text.Trim(),
                    txtDocSpec.Text.Trim()
                );

                MessageBox.Show("Doctor added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearDoctorFields();
                LoadDoctors();
                PopulateAppointmentDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Doctor Failed: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDocUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocId.Text))
            {
                MessageBox.Show("Select a doctor from the table to update.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDocLicense.Text.Trim(), out int lic))
            {
                MessageBox.Show("License No must be a valid integer.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int docId = int.Parse(txtDocId.Text);

                db.usp_Doctor_CRUD(
                    "UPDATE", docId, lic,
                    txtDocName.Text.Trim(),
                    txtDocSpec.Text.Trim()
                );

                MessageBox.Show("Doctor updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearDoctorFields();
                LoadDoctors();
                PopulateAppointmentDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Doctor Failed: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDocClear_Click(object sender, EventArgs e)
        {
            ClearDoctorFields();
        }

        private void ClearDoctorFields()
        {
            txtDocId.Clear();
            txtDocLicense.Clear();
            txtDocName.Clear();
            txtDocSpec.Clear();
        }

        private void DgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoctors.Rows[e.RowIndex].Cells["doctorId"].Value != null)
            {
                DataGridViewRow r = dgvDoctors.Rows[e.RowIndex];

                txtDocId.Text = r.Cells["doctorId"].Value.ToString();
                txtDocLicense.Text = r.Cells["licenseNo"].Value.ToString();
                txtDocName.Text = r.Cells["fullName"].Value.ToString();
                txtDocSpec.Text = r.Cells["specialization"].Value.ToString();
            }
        }
        #endregion

        #region APPOINTMENTS LOGIC (Rejects Double Booking)
        private void PopulateAppointmentDropdowns()
        {
            try
            {
                var patients = db.PATIENTs.Where(p => p.patientStatus == "Active")
                                          .Select(p => new
                                          {
                                              p.patientId,
                                              Display = p.fullName + " (#" + p.patientNo + ")"
                                          })
                                          .ToList();

                cmbApptPatient.DataSource = patients;
                cmbApptPatient.DisplayMember = "Display";
                cmbApptPatient.ValueMember = "patientId";

                var doctors = db.DOCTORs.Where(d => !d.specialization.Contains("(Inactive)"))
                                        .Select(d => new
                                        {
                                            d.doctorId,
                                            Display = d.fullName + " (" + d.specialization + ")"
                                        })
                                        .ToList();

                cmbApptDoctor.DataSource = doctors;
                cmbApptDoctor.DisplayMember = "Display";
                cmbApptDoctor.ValueMember = "doctorId";
            }
            catch { }
        }

        private void LoadAppointments()
        {
            try
            {
                db = new DataClasses1DataContext();

                var list = (from a in db.APPOINTMENTs
                            join p in db.PATIENTs on a.patientId equals p.patientId
                            join d in db.DOCTORs on a.doctorId equals d.doctorId
                            orderby a.appointmentId ascending
                            select new
                            {
                                AppointmentID = a.appointmentId,
                                Patient = p.fullName,
                                Doctor = d.fullName,
                                DateTime = a.appointmentDateTime,
                                Status = a.appointmentStatus
                            }).ToList();

                dgvAppointments.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApptSchedule_Click(object sender, EventArgs e)
        {
            if (cmbApptPatient.SelectedValue == null ||
                cmbApptDoctor.SelectedValue == null)
            {
                MessageBox.Show("Please select both an active patient and an active doctor.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int patId = (int)cmbApptPatient.SelectedValue;
            int docId = (int)cmbApptDoctor.SelectedValue;
            DateTime apptTime = dtpApptDateTime.Value;

            bool isDoctorAlreadyBooked = db.APPOINTMENTs.Any(
                a => a.doctorId == docId && a.appointmentDateTime == apptTime
            );

            if (isDoctorAlreadyBooked)
            {
                MessageBox.Show(
                    "Rejected: Doctor already booked at this exact date and time!\nNo appointment created.",
                    "Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                db.usp_Appointment_Schedule(patId, docId, apptTime);

                MessageBox.Show("Appointment successfully scheduled!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
                PopulateInvoiceAppointmentDropdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking Error: " + ex.Message,
                    "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApptRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointments();
            PopulateAppointmentDropdowns();
        }
        #endregion

        #region BILLING & INVOICES LOGIC (Rejects Invoices with No Lines)
        private void PopulateInvoiceAppointmentDropdown()
        {
            try
            {
                var invoicedApptIds = db.INVOICEs.Select(i => i.appointmentId).ToList();

                var unbilled = (from a in db.APPOINTMENTs
                                join p in db.PATIENTs on a.patientId equals p.patientId
                                where !invoicedApptIds.Contains(a.appointmentId)
                                select new
                                {
                                    a.appointmentId,
                                    Display = $"Appt #{a.appointmentId} - {p.fullName} ({a.appointmentDateTime:yyyy-MM-dd HH:mm})"
                                }).ToList();

                cmbInvAppt.DataSource = unbilled;
                cmbInvAppt.DisplayMember = "Display";
                cmbInvAppt.ValueMember = "appointmentId";

                var services = db.SERVICEs
                                 .Select(s => new
                                 {
                                     s.serviceId,
                                     s.serviceName,
                                     s.standardFee
                                 })
                                 .ToList();

                cmbInvService.DataSource = services;
                cmbInvService.DisplayMember = "serviceName";
                cmbInvService.ValueMember = "serviceId";

                if (services.Count > 0)
                    txtInvUnitFee.Text = services[0].standardFee.ToString("F2");
            }
            catch { }
        }

        private void CmbInvService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInvService.SelectedValue != null &&
                int.TryParse(cmbInvService.SelectedValue.ToString(), out int sId))
            {
                var s = db.SERVICEs.FirstOrDefault(x => x.serviceId == sId);

                if (s != null)
                {
                    txtInvUnitFee.Text = s.standardFee.ToString("F2");
                }
            }
        }

        private void BtnInvCreate_Click(object sender, EventArgs e)
        {
            if (cmbInvAppt.SelectedValue == null)
            {
                MessageBox.Show("Rejected: No appointment selected.",
                    "Action Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbInvService.SelectedValue == null)
            {
                MessageBox.Show("Rejected: Cannot create an invoice without a valid service line item.",
                    "Action Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)numInvQty.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Rejected: Quantity must be greater than zero. No invoice created.",
                    "Action Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtInvUnitFee.Text.Trim(), out decimal fee) || fee < 0)
            {
                MessageBox.Show("Rejected: Unit Fee must be a valid non-negative number.",
                    "Action Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int apptId = (int)cmbInvAppt.SelectedValue;
            int serviceId = (int)cmbInvService.SelectedValue;
            string payStatus = cmbInvPayStatus.SelectedItem.ToString();

            try
            {
                db.usp_Invoice_CreateWithLines(apptId, payStatus, serviceId, qty, fee);

                MessageBox.Show("Invoice & Line Item successfully generated!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadInvoices();
                PopulateInvoiceAppointmentDropdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invoice Rejected (Transaction rolled back): " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInvRefresh_Click(object sender, EventArgs e)
        {
            LoadInvoices();
            PopulateInvoiceAppointmentDropdown();
        }

        private void LoadInvoices()
        {
            try
            {
                db = new DataClasses1DataContext();

                var invoices = (from i in db.INVOICEs
                                join a in db.APPOINTMENTs on i.appointmentId equals a.appointmentId
                                join p in db.PATIENTs on a.patientId equals p.patientId
                                orderby i.invoiceId ascending
                                select new
                                {
                                    InvoiceID = i.invoiceId,
                                    AppointmentID = i.appointmentId,
                                    Patient = p.fullName,
                                    Date = i.invoiceDate,
                                    TotalAmount = i.totalAmount,
                                    Status = i.paymentStatus
                                }).ToList();

                dgvInvoices.DataSource = invoices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoices: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region APPOINTMENT REPORT LOGIC
        private void BtnLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                db = new DataClasses1DataContext();

                var report = db.usp_AppointmentReport_Get()
                               .OrderBy(r => r.appointmentId)
                               .ToList();

                dgvReport.DataSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void LoadAllData()
        {
            LoadPatients();
            LoadDoctors();
            LoadAppointments();
            LoadInvoices();
            PopulateAppointmentDropdowns();
            PopulateInvoiceAppointmentDropdown();
            LoadReport();
        }
    }
}