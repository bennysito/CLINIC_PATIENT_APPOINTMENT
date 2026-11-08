namespace JAMES_CODEV2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CABUSAO_FINAL")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAPPOINTMENT(APPOINTMENT instance);
    partial void UpdateAPPOINTMENT(APPOINTMENT instance);
    partial void DeleteAPPOINTMENT(APPOINTMENT instance);
    partial void InsertDOCTOR(DOCTOR instance);
    partial void UpdateDOCTOR(DOCTOR instance);
    partial void DeleteDOCTOR(DOCTOR instance);
    partial void InsertINVOICE_LINE(INVOICE_LINE instance);
    partial void UpdateINVOICE_LINE(INVOICE_LINE instance);
    partial void DeleteINVOICE_LINE(INVOICE_LINE instance);
    partial void InsertINVOICE(INVOICE instance);
    partial void UpdateINVOICE(INVOICE instance);
    partial void DeleteINVOICE(INVOICE instance);
    partial void InsertPATIENT(PATIENT instance);
    partial void UpdatePATIENT(PATIENT instance);
    partial void DeletePATIENT(PATIENT instance);
    partial void InsertSERVICE(SERVICE instance);
    partial void UpdateSERVICE(SERVICE instance);
    partial void DeleteSERVICE(SERVICE instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::CLINIC_PATIENT_APPOINTMENT.Properties.Settings.Default.CABUSAO_FINALConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<APPOINTMENT> APPOINTMENTs
		{
			get
			{
				return this.GetTable<APPOINTMENT>();
			}
		}
		
		public System.Data.Linq.Table<DOCTOR> DOCTORs
		{
			get
			{
				return this.GetTable<DOCTOR>();
			}
		}
		
		public System.Data.Linq.Table<INVOICE_LINE> INVOICE_LINEs
		{
			get
			{
				return this.GetTable<INVOICE_LINE>();
			}
		}
		
		public System.Data.Linq.Table<INVOICE> INVOICEs
		{
			get
			{
				return this.GetTable<INVOICE>();
			}
		}
		
		public System.Data.Linq.Table<PATIENT> PATIENTs
		{
			get
			{
				return this.GetTable<PATIENT>();
			}
		}
		
		public System.Data.Linq.Table<SERVICE> SERVICEs
		{
			get
			{
				return this.GetTable<SERVICE>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_Appointment_Schedule")]
		public int usp_Appointment_Schedule([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PatientId", DbType="Int")] System.Nullable<int> patientId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorId", DbType="Int")] System.Nullable<int> doctorId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AppointmentDateTime", DbType="DateTime")] System.Nullable<System.DateTime> appointmentDateTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), patientId, doctorId, appointmentDateTime);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_AppointmentReport_Get")]
		public ISingleResult<usp_AppointmentReport_GetResult> usp_AppointmentReport_Get()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<usp_AppointmentReport_GetResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_Doctor_CRUD")]
		public ISingleResult<usp_Doctor_CRUDResult> usp_Doctor_CRUD([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Action", DbType="VarChar(10)")] string action, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorId", DbType="Int")] System.Nullable<int> doctorId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LicenseNo", DbType="Int")] System.Nullable<int> licenseNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullName", DbType="VarChar(50)")] string fullName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Specialization", DbType="VarChar(50)")] string specialization)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), action, doctorId, licenseNo, fullName, specialization);
			return ((ISingleResult<usp_Doctor_CRUDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_Doctor_GetAll")]
		public ISingleResult<usp_Doctor_GetAllResult> usp_Doctor_GetAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<usp_Doctor_GetAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_Invoice_CreateWithLines")]
		public ISingleResult<usp_Invoice_CreateWithLinesResult> usp_Invoice_CreateWithLines([global::System.Data.Linq.Mapping.ParameterAttribute(Name="AppointmentId", DbType="Int")] System.Nullable<int> appointmentId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PaymentStatus", DbType="VarChar(20)")] string paymentStatus, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ServiceId", DbType="Int")] System.Nullable<int> serviceId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Quantity", DbType="Int")] System.Nullable<int> quantity, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnitFee", DbType="Decimal(10,2)")] System.Nullable<decimal> unitFee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appointmentId, paymentStatus, serviceId, quantity, unitFee);
			return ((ISingleResult<usp_Invoice_CreateWithLinesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_Patient_CRUD")]
		public ISingleResult<usp_Patient_CRUDResult> usp_Patient_CRUD([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Action", DbType="VarChar(10)")] string action, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PatientId", DbType="Int")] System.Nullable<int> patientId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PatientNo", DbType="Int")] System.Nullable<int> patientNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullName", DbType="VarChar(50)")] string fullName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BirthDate", DbType="Date")] System.Nullable<System.DateTime> birthDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sex", DbType="VarChar(10)")] string sex, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ContactNumber", DbType="VarChar(11)")] string contactNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PatientStatus", DbType="VarChar(10)")] string patientStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), action, patientId, patientNo, fullName, birthDate, sex, contactNumber, patientStatus);
			return ((ISingleResult<usp_Patient_CRUDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_Patient_Search")]
		public ISingleResult<usp_Patient_SearchResult> usp_Patient_Search([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Keyword", DbType="VarChar(100)")] string keyword)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), keyword);
			return ((ISingleResult<usp_Patient_SearchResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.APPOINTMENTS")]
	public partial class APPOINTMENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _appointmentId;
		
		private int _patientId;
		
		private int _doctorId;
		
		private System.DateTime _appointmentDateTime;
		
		private string _appointmentStatus;
		
		private EntitySet<INVOICE> _INVOICEs;
		
		private EntityRef<DOCTOR> _DOCTOR;
		
		private EntityRef<PATIENT> _PATIENT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnappointmentIdChanging(int value);
    partial void OnappointmentIdChanged();
    partial void OnpatientIdChanging(int value);
    partial void OnpatientIdChanged();
    partial void OndoctorIdChanging(int value);
    partial void OndoctorIdChanged();
    partial void OnappointmentDateTimeChanging(System.DateTime value);
    partial void OnappointmentDateTimeChanged();
    partial void OnappointmentStatusChanging(string value);
    partial void OnappointmentStatusChanged();
    #endregion
		
		public APPOINTMENT()
		{
			this._INVOICEs = new EntitySet<INVOICE>(new Action<INVOICE>(this.attach_INVOICEs), new Action<INVOICE>(this.detach_INVOICEs));
			this._DOCTOR = default(EntityRef<DOCTOR>);
			this._PATIENT = default(EntityRef<PATIENT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appointmentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int appointmentId
		{
			get
			{
				return this._appointmentId;
			}
			set
			{
				if ((this._appointmentId != value))
				{
					this.OnappointmentIdChanging(value);
					this.SendPropertyChanging();
					this._appointmentId = value;
					this.SendPropertyChanged("appointmentId");
					this.OnappointmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientId", DbType="Int NOT NULL")]
		public int patientId
		{
			get
			{
				return this._patientId;
			}
			set
			{
				if ((this._patientId != value))
				{
					if (this._PATIENT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpatientIdChanging(value);
					this.SendPropertyChanging();
					this._patientId = value;
					this.SendPropertyChanged("patientId");
					this.OnpatientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doctorId", DbType="Int NOT NULL")]
		public int doctorId
		{
			get
			{
				return this._doctorId;
			}
			set
			{
				if ((this._doctorId != value))
				{
					if (this._DOCTOR.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndoctorIdChanging(value);
					this.SendPropertyChanging();
					this._doctorId = value;
					this.SendPropertyChanged("doctorId");
					this.OndoctorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appointmentDateTime", DbType="DateTime NOT NULL")]
		public System.DateTime appointmentDateTime
		{
			get
			{
				return this._appointmentDateTime;
			}
			set
			{
				if ((this._appointmentDateTime != value))
				{
					this.OnappointmentDateTimeChanging(value);
					this.SendPropertyChanging();
					this._appointmentDateTime = value;
					this.SendPropertyChanged("appointmentDateTime");
					this.OnappointmentDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appointmentStatus", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string appointmentStatus
		{
			get
			{
				return this._appointmentStatus;
			}
			set
			{
				if ((this._appointmentStatus != value))
				{
					this.OnappointmentStatusChanging(value);
					this.SendPropertyChanging();
					this._appointmentStatus = value;
					this.SendPropertyChanged("appointmentStatus");
					this.OnappointmentStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="APPOINTMENT_INVOICE", Storage="_INVOICEs", ThisKey="appointmentId", OtherKey="appointmentId")]
		public EntitySet<INVOICE> INVOICEs
		{
			get
			{
				return this._INVOICEs;
			}
			set
			{
				this._INVOICEs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DOCTOR_APPOINTMENT", Storage="_DOCTOR", ThisKey="doctorId", OtherKey="doctorId", IsForeignKey=true)]
		public DOCTOR DOCTOR
		{
			get
			{
				return this._DOCTOR.Entity;
			}
			set
			{
				DOCTOR previousValue = this._DOCTOR.Entity;
				if (((previousValue != value) 
							|| (this._DOCTOR.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DOCTOR.Entity = null;
						previousValue.APPOINTMENTs.Remove(this);
					}
					this._DOCTOR.Entity = value;
					if ((value != null))
					{
						value.APPOINTMENTs.Add(this);
						this._doctorId = value.doctorId;
					}
					else
					{
						this._doctorId = default(int);
					}
					this.SendPropertyChanged("DOCTOR");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PATIENT_APPOINTMENT", Storage="_PATIENT", ThisKey="patientId", OtherKey="patientId", IsForeignKey=true)]
		public PATIENT PATIENT
		{
			get
			{
				return this._PATIENT.Entity;
			}
			set
			{
				PATIENT previousValue = this._PATIENT.Entity;
				if (((previousValue != value) 
							|| (this._PATIENT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PATIENT.Entity = null;
						previousValue.APPOINTMENTs.Remove(this);
					}
					this._PATIENT.Entity = value;
					if ((value != null))
					{
						value.APPOINTMENTs.Add(this);
						this._patientId = value.patientId;
					}
					else
					{
						this._patientId = default(int);
					}
					this.SendPropertyChanged("PATIENT");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_INVOICEs(INVOICE entity)
		{
			this.SendPropertyChanging();
			entity.APPOINTMENT = this;
		}
		
		private void detach_INVOICEs(INVOICE entity)
		{
			this.SendPropertyChanging();
			entity.APPOINTMENT = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DOCTORS")]
	public partial class DOCTOR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _doctorId;
		
		private int _licenseNo;
		
		private string _fullName;
		
		private string _specialization;
		
		private EntitySet<APPOINTMENT> _APPOINTMENTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndoctorIdChanging(int value);
    partial void OndoctorIdChanged();
    partial void OnlicenseNoChanging(int value);
    partial void OnlicenseNoChanged();
    partial void OnfullNameChanging(string value);
    partial void OnfullNameChanged();
    partial void OnspecializationChanging(string value);
    partial void OnspecializationChanged();
    #endregion
		
		public DOCTOR()
		{
			this._APPOINTMENTs = new EntitySet<APPOINTMENT>(new Action<APPOINTMENT>(this.attach_APPOINTMENTs), new Action<APPOINTMENT>(this.detach_APPOINTMENTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doctorId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int doctorId
		{
			get
			{
				return this._doctorId;
			}
			set
			{
				if ((this._doctorId != value))
				{
					this.OndoctorIdChanging(value);
					this.SendPropertyChanging();
					this._doctorId = value;
					this.SendPropertyChanged("doctorId");
					this.OndoctorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_licenseNo", DbType="Int NOT NULL")]
		public int licenseNo
		{
			get
			{
				return this._licenseNo;
			}
			set
			{
				if ((this._licenseNo != value))
				{
					this.OnlicenseNoChanging(value);
					this.SendPropertyChanging();
					this._licenseNo = value;
					this.SendPropertyChanged("licenseNo");
					this.OnlicenseNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this.OnfullNameChanging(value);
					this.SendPropertyChanging();
					this._fullName = value;
					this.SendPropertyChanged("fullName");
					this.OnfullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_specialization", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string specialization
		{
			get
			{
				return this._specialization;
			}
			set
			{
				if ((this._specialization != value))
				{
					this.OnspecializationChanging(value);
					this.SendPropertyChanging();
					this._specialization = value;
					this.SendPropertyChanged("specialization");
					this.OnspecializationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DOCTOR_APPOINTMENT", Storage="_APPOINTMENTs", ThisKey="doctorId", OtherKey="doctorId")]
		public EntitySet<APPOINTMENT> APPOINTMENTs
		{
			get
			{
				return this._APPOINTMENTs;
			}
			set
			{
				this._APPOINTMENTs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_APPOINTMENTs(APPOINTMENT entity)
		{
			this.SendPropertyChanging();
			entity.DOCTOR = this;
		}
		
		private void detach_APPOINTMENTs(APPOINTMENT entity)
		{
			this.SendPropertyChanging();
			entity.DOCTOR = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.INVOICE_LINES")]
	public partial class INVOICE_LINE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _invoiceLineId;
		
		private int _invoiceId;
		
		private int _serviceId;
		
		private int _quantity;
		
		private decimal _unitFee;
		
		private System.Nullable<decimal> _lineAmount;
		
		private EntityRef<INVOICE> _INVOICE;
		
		private EntityRef<SERVICE> _SERVICE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninvoiceLineIdChanging(int value);
    partial void OninvoiceLineIdChanged();
    partial void OninvoiceIdChanging(int value);
    partial void OninvoiceIdChanged();
    partial void OnserviceIdChanging(int value);
    partial void OnserviceIdChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    partial void OnunitFeeChanging(decimal value);
    partial void OnunitFeeChanged();
    partial void OnlineAmountChanging(System.Nullable<decimal> value);
    partial void OnlineAmountChanged();
    #endregion
		
		public INVOICE_LINE()
		{
			this._INVOICE = default(EntityRef<INVOICE>);
			this._SERVICE = default(EntityRef<SERVICE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceLineId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int invoiceLineId
		{
			get
			{
				return this._invoiceLineId;
			}
			set
			{
				if ((this._invoiceLineId != value))
				{
					this.OninvoiceLineIdChanging(value);
					this.SendPropertyChanging();
					this._invoiceLineId = value;
					this.SendPropertyChanged("invoiceLineId");
					this.OninvoiceLineIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceId", DbType="Int NOT NULL")]
		public int invoiceId
		{
			get
			{
				return this._invoiceId;
			}
			set
			{
				if ((this._invoiceId != value))
				{
					if (this._INVOICE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OninvoiceIdChanging(value);
					this.SendPropertyChanging();
					this._invoiceId = value;
					this.SendPropertyChanged("invoiceId");
					this.OninvoiceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serviceId", DbType="Int NOT NULL")]
		public int serviceId
		{
			get
			{
				return this._serviceId;
			}
			set
			{
				if ((this._serviceId != value))
				{
					if (this._SERVICE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnserviceIdChanging(value);
					this.SendPropertyChanging();
					this._serviceId = value;
					this.SendPropertyChanged("serviceId");
					this.OnserviceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
		public int quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unitFee", DbType="Decimal(10,2) NOT NULL")]
		public decimal unitFee
		{
			get
			{
				return this._unitFee;
			}
			set
			{
				if ((this._unitFee != value))
				{
					this.OnunitFeeChanging(value);
					this.SendPropertyChanging();
					this._unitFee = value;
					this.SendPropertyChanged("unitFee");
					this.OnunitFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lineAmount", AutoSync=AutoSync.Always, DbType="Decimal(21,2)", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<decimal> lineAmount
		{
			get
			{
				return this._lineAmount;
			}
			set
			{
				if ((this._lineAmount != value))
				{
					this.OnlineAmountChanging(value);
					this.SendPropertyChanging();
					this._lineAmount = value;
					this.SendPropertyChanged("lineAmount");
					this.OnlineAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="INVOICE_INVOICE_LINE", Storage="_INVOICE", ThisKey="invoiceId", OtherKey="invoiceId", IsForeignKey=true)]
		public INVOICE INVOICE
		{
			get
			{
				return this._INVOICE.Entity;
			}
			set
			{
				INVOICE previousValue = this._INVOICE.Entity;
				if (((previousValue != value) 
							|| (this._INVOICE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._INVOICE.Entity = null;
						previousValue.INVOICE_LINEs.Remove(this);
					}
					this._INVOICE.Entity = value;
					if ((value != null))
					{
						value.INVOICE_LINEs.Add(this);
						this._invoiceId = value.invoiceId;
					}
					else
					{
						this._invoiceId = default(int);
					}
					this.SendPropertyChanged("INVOICE");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SERVICE_INVOICE_LINE", Storage="_SERVICE", ThisKey="serviceId", OtherKey="serviceId", IsForeignKey=true)]
		public SERVICE SERVICE
		{
			get
			{
				return this._SERVICE.Entity;
			}
			set
			{
				SERVICE previousValue = this._SERVICE.Entity;
				if (((previousValue != value) 
							|| (this._SERVICE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SERVICE.Entity = null;
						previousValue.INVOICE_LINEs.Remove(this);
					}
					this._SERVICE.Entity = value;
					if ((value != null))
					{
						value.INVOICE_LINEs.Add(this);
						this._serviceId = value.serviceId;
					}
					else
					{
						this._serviceId = default(int);
					}
					this.SendPropertyChanged("SERVICE");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.INVOICES")]
	public partial class INVOICE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _invoiceId;
		
		private int _appointmentId;
		
		private System.DateTime _invoiceDate;
		
		private decimal _totalAmount;
		
		private string _paymentStatus;
		
		private EntitySet<INVOICE_LINE> _INVOICE_LINEs;
		
		private EntityRef<APPOINTMENT> _APPOINTMENT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninvoiceIdChanging(int value);
    partial void OninvoiceIdChanged();
    partial void OnappointmentIdChanging(int value);
    partial void OnappointmentIdChanged();
    partial void OninvoiceDateChanging(System.DateTime value);
    partial void OninvoiceDateChanged();
    partial void OntotalAmountChanging(decimal value);
    partial void OntotalAmountChanged();
    partial void OnpaymentStatusChanging(string value);
    partial void OnpaymentStatusChanged();
    #endregion
		
		public INVOICE()
		{
			this._INVOICE_LINEs = new EntitySet<INVOICE_LINE>(new Action<INVOICE_LINE>(this.attach_INVOICE_LINEs), new Action<INVOICE_LINE>(this.detach_INVOICE_LINEs));
			this._APPOINTMENT = default(EntityRef<APPOINTMENT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int invoiceId
		{
			get
			{
				return this._invoiceId;
			}
			set
			{
				if ((this._invoiceId != value))
				{
					this.OninvoiceIdChanging(value);
					this.SendPropertyChanging();
					this._invoiceId = value;
					this.SendPropertyChanged("invoiceId");
					this.OninvoiceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appointmentId", DbType="Int NOT NULL")]
		public int appointmentId
		{
			get
			{
				return this._appointmentId;
			}
			set
			{
				if ((this._appointmentId != value))
				{
					if (this._APPOINTMENT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnappointmentIdChanging(value);
					this.SendPropertyChanging();
					this._appointmentId = value;
					this.SendPropertyChanged("appointmentId");
					this.OnappointmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceDate", DbType="DateTime NOT NULL")]
		public System.DateTime invoiceDate
		{
			get
			{
				return this._invoiceDate;
			}
			set
			{
				if ((this._invoiceDate != value))
				{
					this.OninvoiceDateChanging(value);
					this.SendPropertyChanging();
					this._invoiceDate = value;
					this.SendPropertyChanged("invoiceDate");
					this.OninvoiceDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalAmount", DbType="Decimal(10,2) NOT NULL")]
		public decimal totalAmount
		{
			get
			{
				return this._totalAmount;
			}
			set
			{
				if ((this._totalAmount != value))
				{
					this.OntotalAmountChanging(value);
					this.SendPropertyChanging();
					this._totalAmount = value;
					this.SendPropertyChanged("totalAmount");
					this.OntotalAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paymentStatus", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string paymentStatus
		{
			get
			{
				return this._paymentStatus;
			}
			set
			{
				if ((this._paymentStatus != value))
				{
					this.OnpaymentStatusChanging(value);
					this.SendPropertyChanging();
					this._paymentStatus = value;
					this.SendPropertyChanged("paymentStatus");
					this.OnpaymentStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="INVOICE_INVOICE_LINE", Storage="_INVOICE_LINEs", ThisKey="invoiceId", OtherKey="invoiceId")]
		public EntitySet<INVOICE_LINE> INVOICE_LINEs
		{
			get
			{
				return this._INVOICE_LINEs;
			}
			set
			{
				this._INVOICE_LINEs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="APPOINTMENT_INVOICE", Storage="_APPOINTMENT", ThisKey="appointmentId", OtherKey="appointmentId", IsForeignKey=true)]
		public APPOINTMENT APPOINTMENT
		{
			get
			{
				return this._APPOINTMENT.Entity;
			}
			set
			{
				APPOINTMENT previousValue = this._APPOINTMENT.Entity;
				if (((previousValue != value) 
							|| (this._APPOINTMENT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._APPOINTMENT.Entity = null;
						previousValue.INVOICEs.Remove(this);
					}
					this._APPOINTMENT.Entity = value;
					if ((value != null))
					{
						value.INVOICEs.Add(this);
						this._appointmentId = value.appointmentId;
					}
					else
					{
						this._appointmentId = default(int);
					}
					this.SendPropertyChanged("APPOINTMENT");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_INVOICE_LINEs(INVOICE_LINE entity)
		{
			this.SendPropertyChanging();
			entity.INVOICE = this;
		}
		
		private void detach_INVOICE_LINEs(INVOICE_LINE entity)
		{
			this.SendPropertyChanging();
			entity.INVOICE = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PATIENTS")]
	public partial class PATIENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _patientId;
		
		private int _patientNo;
		
		private string _fullName;
		
		private System.DateTime _birthDate;
		
		private string _sex;
		
		private string _contactNumber;
		
		private string _patientStatus;
		
		private EntitySet<APPOINTMENT> _APPOINTMENTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpatientIdChanging(int value);
    partial void OnpatientIdChanged();
    partial void OnpatientNoChanging(int value);
    partial void OnpatientNoChanged();
    partial void OnfullNameChanging(string value);
    partial void OnfullNameChanged();
    partial void OnbirthDateChanging(System.DateTime value);
    partial void OnbirthDateChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OncontactNumberChanging(string value);
    partial void OncontactNumberChanged();
    partial void OnpatientStatusChanging(string value);
    partial void OnpatientStatusChanged();
    #endregion
		
		public PATIENT()
		{
			this._APPOINTMENTs = new EntitySet<APPOINTMENT>(new Action<APPOINTMENT>(this.attach_APPOINTMENTs), new Action<APPOINTMENT>(this.detach_APPOINTMENTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int patientId
		{
			get
			{
				return this._patientId;
			}
			set
			{
				if ((this._patientId != value))
				{
					this.OnpatientIdChanging(value);
					this.SendPropertyChanging();
					this._patientId = value;
					this.SendPropertyChanged("patientId");
					this.OnpatientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientNo", DbType="Int NOT NULL")]
		public int patientNo
		{
			get
			{
				return this._patientNo;
			}
			set
			{
				if ((this._patientNo != value))
				{
					this.OnpatientNoChanging(value);
					this.SendPropertyChanging();
					this._patientNo = value;
					this.SendPropertyChanged("patientNo");
					this.OnpatientNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this.OnfullNameChanging(value);
					this.SendPropertyChanging();
					this._fullName = value;
					this.SendPropertyChanged("fullName");
					this.OnfullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthDate", DbType="Date NOT NULL")]
		public System.DateTime birthDate
		{
			get
			{
				return this._birthDate;
			}
			set
			{
				if ((this._birthDate != value))
				{
					this.OnbirthDateChanging(value);
					this.SendPropertyChanging();
					this._birthDate = value;
					this.SendPropertyChanged("birthDate");
					this.OnbirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactNumber", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string contactNumber
		{
			get
			{
				return this._contactNumber;
			}
			set
			{
				if ((this._contactNumber != value))
				{
					this.OncontactNumberChanging(value);
					this.SendPropertyChanging();
					this._contactNumber = value;
					this.SendPropertyChanged("contactNumber");
					this.OncontactNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientStatus", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string patientStatus
		{
			get
			{
				return this._patientStatus;
			}
			set
			{
				if ((this._patientStatus != value))
				{
					this.OnpatientStatusChanging(value);
					this.SendPropertyChanging();
					this._patientStatus = value;
					this.SendPropertyChanged("patientStatus");
					this.OnpatientStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PATIENT_APPOINTMENT", Storage="_APPOINTMENTs", ThisKey="patientId", OtherKey="patientId")]
		public EntitySet<APPOINTMENT> APPOINTMENTs
		{
			get
			{
				return this._APPOINTMENTs;
			}
			set
			{
				this._APPOINTMENTs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_APPOINTMENTs(APPOINTMENT entity)
		{
			this.SendPropertyChanging();
			entity.PATIENT = this;
		}
		
		private void detach_APPOINTMENTs(APPOINTMENT entity)
		{
			this.SendPropertyChanging();
			entity.PATIENT = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SERVICES")]
	public partial class SERVICE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _serviceId;
		
		private string _serviceCode;
		
		private string _serviceName;
		
		private decimal _standardFee;
		
		private EntitySet<INVOICE_LINE> _INVOICE_LINEs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnserviceIdChanging(int value);
    partial void OnserviceIdChanged();
    partial void OnserviceCodeChanging(string value);
    partial void OnserviceCodeChanged();
    partial void OnserviceNameChanging(string value);
    partial void OnserviceNameChanged();
    partial void OnstandardFeeChanging(decimal value);
    partial void OnstandardFeeChanged();
    #endregion
		
		public SERVICE()
		{
			this._INVOICE_LINEs = new EntitySet<INVOICE_LINE>(new Action<INVOICE_LINE>(this.attach_INVOICE_LINEs), new Action<INVOICE_LINE>(this.detach_INVOICE_LINEs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serviceId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int serviceId
		{
			get
			{
				return this._serviceId;
			}
			set
			{
				if ((this._serviceId != value))
				{
					this.OnserviceIdChanging(value);
					this.SendPropertyChanging();
					this._serviceId = value;
					this.SendPropertyChanged("serviceId");
					this.OnserviceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serviceCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string serviceCode
		{
			get
			{
				return this._serviceCode;
			}
			set
			{
				if ((this._serviceCode != value))
				{
					this.OnserviceCodeChanging(value);
					this.SendPropertyChanging();
					this._serviceCode = value;
					this.SendPropertyChanged("serviceCode");
					this.OnserviceCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serviceName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string serviceName
		{
			get
			{
				return this._serviceName;
			}
			set
			{
				if ((this._serviceName != value))
				{
					this.OnserviceNameChanging(value);
					this.SendPropertyChanging();
					this._serviceName = value;
					this.SendPropertyChanged("serviceName");
					this.OnserviceNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_standardFee", DbType="Decimal(10,2) NOT NULL")]
		public decimal standardFee
		{
			get
			{
				return this._standardFee;
			}
			set
			{
				if ((this._standardFee != value))
				{
					this.OnstandardFeeChanging(value);
					this.SendPropertyChanging();
					this._standardFee = value;
					this.SendPropertyChanged("standardFee");
					this.OnstandardFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SERVICE_INVOICE_LINE", Storage="_INVOICE_LINEs", ThisKey="serviceId", OtherKey="serviceId")]
		public EntitySet<INVOICE_LINE> INVOICE_LINEs
		{
			get
			{
				return this._INVOICE_LINEs;
			}
			set
			{
				this._INVOICE_LINEs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_INVOICE_LINEs(INVOICE_LINE entity)
		{
			this.SendPropertyChanging();
			entity.SERVICE = this;
		}
		
		private void detach_INVOICE_LINEs(INVOICE_LINE entity)
		{
			this.SendPropertyChanging();
			entity.SERVICE = null;
		}
	}
	
	public partial class usp_AppointmentReport_GetResult
	{
		
		private int _appointmentId;
		
		private int _patientNo;
		
		private string _PatientName;
		
		private string _DoctorName;
		
		private string _specialization;
		
		private System.DateTime _appointmentDateTime;
		
		private string _appointmentStatus;
		
		private System.Nullable<int> _invoiceId;
		
		private System.Nullable<System.DateTime> _invoiceDate;
		
		private System.Nullable<decimal> _totalAmount;
		
		private string _paymentStatus;
		
		public usp_AppointmentReport_GetResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appointmentId", DbType="Int NOT NULL")]
		public int appointmentId
		{
			get
			{
				return this._appointmentId;
			}
			set
			{
				if ((this._appointmentId != value))
				{
					this._appointmentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientNo", DbType="Int NOT NULL")]
		public int patientNo
		{
			get
			{
				return this._patientNo;
			}
			set
			{
				if ((this._patientNo != value))
				{
					this._patientNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PatientName
		{
			get
			{
				return this._PatientName;
			}
			set
			{
				if ((this._PatientName != value))
				{
					this._PatientName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DoctorName
		{
			get
			{
				return this._DoctorName;
			}
			set
			{
				if ((this._DoctorName != value))
				{
					this._DoctorName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_specialization", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string specialization
		{
			get
			{
				return this._specialization;
			}
			set
			{
				if ((this._specialization != value))
				{
					this._specialization = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appointmentDateTime", DbType="DateTime NOT NULL")]
		public System.DateTime appointmentDateTime
		{
			get
			{
				return this._appointmentDateTime;
			}
			set
			{
				if ((this._appointmentDateTime != value))
				{
					this._appointmentDateTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appointmentStatus", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string appointmentStatus
		{
			get
			{
				return this._appointmentStatus;
			}
			set
			{
				if ((this._appointmentStatus != value))
				{
					this._appointmentStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceId", DbType="Int")]
		public System.Nullable<int> invoiceId
		{
			get
			{
				return this._invoiceId;
			}
			set
			{
				if ((this._invoiceId != value))
				{
					this._invoiceId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> invoiceDate
		{
			get
			{
				return this._invoiceDate;
			}
			set
			{
				if ((this._invoiceDate != value))
				{
					this._invoiceDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalAmount", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> totalAmount
		{
			get
			{
				return this._totalAmount;
			}
			set
			{
				if ((this._totalAmount != value))
				{
					this._totalAmount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paymentStatus", DbType="VarChar(20)")]
		public string paymentStatus
		{
			get
			{
				return this._paymentStatus;
			}
			set
			{
				if ((this._paymentStatus != value))
				{
					this._paymentStatus = value;
				}
			}
		}
	}
	
	public partial class usp_Doctor_CRUDResult
	{
		
		private int _doctorId;
		
		private int _licenseNo;
		
		private string _fullName;
		
		private string _specialization;
		
		public usp_Doctor_CRUDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doctorId", DbType="Int NOT NULL")]
		public int doctorId
		{
			get
			{
				return this._doctorId;
			}
			set
			{
				if ((this._doctorId != value))
				{
					this._doctorId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_licenseNo", DbType="Int NOT NULL")]
		public int licenseNo
		{
			get
			{
				return this._licenseNo;
			}
			set
			{
				if ((this._licenseNo != value))
				{
					this._licenseNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this._fullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_specialization", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string specialization
		{
			get
			{
				return this._specialization;
			}
			set
			{
				if ((this._specialization != value))
				{
					this._specialization = value;
				}
			}
		}
	}
	
	public partial class usp_Doctor_GetAllResult
	{
		
		private int _doctorId;
		
		private int _licenseNo;
		
		private string _fullName;
		
		private string _specialization;
		
		public usp_Doctor_GetAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doctorId", DbType="Int NOT NULL")]
		public int doctorId
		{
			get
			{
				return this._doctorId;
			}
			set
			{
				if ((this._doctorId != value))
				{
					this._doctorId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_licenseNo", DbType="Int NOT NULL")]
		public int licenseNo
		{
			get
			{
				return this._licenseNo;
			}
			set
			{
				if ((this._licenseNo != value))
				{
					this._licenseNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this._fullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_specialization", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string specialization
		{
			get
			{
				return this._specialization;
			}
			set
			{
				if ((this._specialization != value))
				{
					this._specialization = value;
				}
			}
		}
	}
	
	public partial class usp_Invoice_CreateWithLinesResult
	{
		
		private System.Nullable<int> _InvoiceId;
		
		private System.Nullable<int> _AppointmentId;
		
		private string _PaymentStatus;
		
		public usp_Invoice_CreateWithLinesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvoiceId", DbType="Int")]
		public System.Nullable<int> InvoiceId
		{
			get
			{
				return this._InvoiceId;
			}
			set
			{
				if ((this._InvoiceId != value))
				{
					this._InvoiceId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentId", DbType="Int")]
		public System.Nullable<int> AppointmentId
		{
			get
			{
				return this._AppointmentId;
			}
			set
			{
				if ((this._AppointmentId != value))
				{
					this._AppointmentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentStatus", DbType="VarChar(20)")]
		public string PaymentStatus
		{
			get
			{
				return this._PaymentStatus;
			}
			set
			{
				if ((this._PaymentStatus != value))
				{
					this._PaymentStatus = value;
				}
			}
		}
	}
	
	public partial class usp_Patient_CRUDResult
	{
		
		private int _patientId;
		
		private int _patientNo;
		
		private string _fullName;
		
		private System.DateTime _birthDate;
		
		private string _sex;
		
		private string _contactNumber;
		
		private string _patientStatus;
		
		public usp_Patient_CRUDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientId", DbType="Int NOT NULL")]
		public int patientId
		{
			get
			{
				return this._patientId;
			}
			set
			{
				if ((this._patientId != value))
				{
					this._patientId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientNo", DbType="Int NOT NULL")]
		public int patientNo
		{
			get
			{
				return this._patientNo;
			}
			set
			{
				if ((this._patientNo != value))
				{
					this._patientNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this._fullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthDate", DbType="Date NOT NULL")]
		public System.DateTime birthDate
		{
			get
			{
				return this._birthDate;
			}
			set
			{
				if ((this._birthDate != value))
				{
					this._birthDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this._sex = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactNumber", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string contactNumber
		{
			get
			{
				return this._contactNumber;
			}
			set
			{
				if ((this._contactNumber != value))
				{
					this._contactNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientStatus", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string patientStatus
		{
			get
			{
				return this._patientStatus;
			}
			set
			{
				if ((this._patientStatus != value))
				{
					this._patientStatus = value;
				}
			}
		}
	}
	
	public partial class usp_Patient_SearchResult
	{
		
		private int _patientId;
		
		private int _patientNo;
		
		private string _fullName;
		
		private System.DateTime _birthDate;
		
		private string _sex;
		
		private string _contactNumber;
		
		private string _patientStatus;
		
		public usp_Patient_SearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientId", DbType="Int NOT NULL")]
		public int patientId
		{
			get
			{
				return this._patientId;
			}
			set
			{
				if ((this._patientId != value))
				{
					this._patientId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientNo", DbType="Int NOT NULL")]
		public int patientNo
		{
			get
			{
				return this._patientNo;
			}
			set
			{
				if ((this._patientNo != value))
				{
					this._patientNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this._fullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthDate", DbType="Date NOT NULL")]
		public System.DateTime birthDate
		{
			get
			{
				return this._birthDate;
			}
			set
			{
				if ((this._birthDate != value))
				{
					this._birthDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this._sex = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactNumber", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string contactNumber
		{
			get
			{
				return this._contactNumber;
			}
			set
			{
				if ((this._contactNumber != value))
				{
					this._contactNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientStatus", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string patientStatus
		{
			get
			{
				return this._patientStatus;
			}
			set
			{
				if ((this._patientStatus != value))
				{
					this._patientStatus = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
