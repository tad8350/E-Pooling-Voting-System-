﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36366
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Polling
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="National Database System")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertCandidate(Candidate instance);
    partial void UpdateCandidate(Candidate instance);
    partial void DeleteCandidate(Candidate instance);
    partial void InsertNID_Info1(NID_Info1 instance);
    partial void UpdateNID_Info1(NID_Info1 instance);
    partial void DeleteNID_Info1(NID_Info1 instance);
    partial void InsertVoter(Voter instance);
    partial void UpdateVoter(Voter instance);
    partial void DeleteVoter(Voter instance);
    #endregion
		
		public DBDataContext() : 
				base(global::E_Polling.Properties.Settings.Default.National_Database_SystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Candidate> Candidates
		{
			get
			{
				return this.GetTable<Candidate>();
			}
		}
		
		public System.Data.Linq.Table<NID_Info1> NID_Info1s
		{
			get
			{
				return this.GetTable<NID_Info1>();
			}
		}
		
		public System.Data.Linq.Table<Voter> Voters
		{
			get
			{
				return this.GetTable<Voter>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NID;
		
		private string _Password;
		
		private System.DateTime _Election_Date;
		
		private EntityRef<NID_Info1> _NID_Info1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNIDChanging(string value);
    partial void OnNIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnElection_DateChanging(System.DateTime value);
    partial void OnElection_DateChanged();
    #endregion
		
		public Admin()
		{
			this._NID_Info1 = default(EntityRef<NID_Info1>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NID
		{
			get
			{
				return this._NID;
			}
			set
			{
				if ((this._NID != value))
				{
					if (this._NID_Info1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNIDChanging(value);
					this.SendPropertyChanging();
					this._NID = value;
					this.SendPropertyChanged("NID");
					this.OnNIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Election Date]", Storage="_Election_Date", DbType="Date NOT NULL")]
		public System.DateTime Election_Date
		{
			get
			{
				return this._Election_Date;
			}
			set
			{
				if ((this._Election_Date != value))
				{
					this.OnElection_DateChanging(value);
					this.SendPropertyChanging();
					this._Election_Date = value;
					this.SendPropertyChanged("Election_Date");
					this.OnElection_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NID_Info1_Admin", Storage="_NID_Info1", ThisKey="NID", OtherKey="NID", IsForeignKey=true)]
		public NID_Info1 NID_Info1
		{
			get
			{
				return this._NID_Info1.Entity;
			}
			set
			{
				NID_Info1 previousValue = this._NID_Info1.Entity;
				if (((previousValue != value) 
							|| (this._NID_Info1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NID_Info1.Entity = null;
						previousValue.Admin = null;
					}
					this._NID_Info1.Entity = value;
					if ((value != null))
					{
						value.Admin = this;
						this._NID = value.NID;
					}
					else
					{
						this._NID = default(string);
					}
					this.SendPropertyChanged("NID_Info1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Candidate")]
	public partial class Candidate : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NID;
		
		private string _Name;
		
		private string _Party_Name;
		
		private string _Logo;
		
		private string _Total_Vote;
		
		private EntityRef<NID_Info1> _NID_Info1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNIDChanging(string value);
    partial void OnNIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnParty_NameChanging(string value);
    partial void OnParty_NameChanged();
    partial void OnLogoChanging(string value);
    partial void OnLogoChanged();
    partial void OnTotal_VoteChanging(string value);
    partial void OnTotal_VoteChanged();
    #endregion
		
		public Candidate()
		{
			this._NID_Info1 = default(EntityRef<NID_Info1>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NID
		{
			get
			{
				return this._NID;
			}
			set
			{
				if ((this._NID != value))
				{
					if (this._NID_Info1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNIDChanging(value);
					this.SendPropertyChanging();
					this._NID = value;
					this.SendPropertyChanged("NID");
					this.OnNIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Party_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Party_Name
		{
			get
			{
				return this._Party_Name;
			}
			set
			{
				if ((this._Party_Name != value))
				{
					this.OnParty_NameChanging(value);
					this.SendPropertyChanging();
					this._Party_Name = value;
					this.SendPropertyChanged("Party_Name");
					this.OnParty_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logo", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Logo
		{
			get
			{
				return this._Logo;
			}
			set
			{
				if ((this._Logo != value))
				{
					this.OnLogoChanging(value);
					this.SendPropertyChanging();
					this._Logo = value;
					this.SendPropertyChanged("Logo");
					this.OnLogoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Vote", DbType="VarChar(50)")]
		public string Total_Vote
		{
			get
			{
				return this._Total_Vote;
			}
			set
			{
				if ((this._Total_Vote != value))
				{
					this.OnTotal_VoteChanging(value);
					this.SendPropertyChanging();
					this._Total_Vote = value;
					this.SendPropertyChanged("Total_Vote");
					this.OnTotal_VoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NID_Info1_Candidate", Storage="_NID_Info1", ThisKey="NID", OtherKey="NID", IsForeignKey=true)]
		public NID_Info1 NID_Info1
		{
			get
			{
				return this._NID_Info1.Entity;
			}
			set
			{
				NID_Info1 previousValue = this._NID_Info1.Entity;
				if (((previousValue != value) 
							|| (this._NID_Info1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NID_Info1.Entity = null;
						previousValue.Candidate = null;
					}
					this._NID_Info1.Entity = value;
					if ((value != null))
					{
						value.Candidate = this;
						this._NID = value.NID;
					}
					else
					{
						this._NID = default(string);
					}
					this.SendPropertyChanged("NID_Info1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NID_Info")]
	public partial class NID_Info1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NID;
		
		private string _Name;
		
		private string _Father_s_Name;
		
		private string _Mother_s_Name;
		
		private string _Sex;
		
		private System.DateTime _DOB;
		
		private string _Blood_Group;
		
		private string _Marital_Status;
		
		private int _Mobile_No;
		
		private string _E_Mail;
		
		private string _Present_Address;
		
		private string _Permanent_Address;
		
		private EntityRef<Admin> _Admin;
		
		private EntityRef<Candidate> _Candidate;
		
		private EntityRef<Voter> _Voter;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNIDChanging(string value);
    partial void OnNIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFather_s_NameChanging(string value);
    partial void OnFather_s_NameChanged();
    partial void OnMother_s_NameChanging(string value);
    partial void OnMother_s_NameChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnDOBChanging(System.DateTime value);
    partial void OnDOBChanged();
    partial void OnBlood_GroupChanging(string value);
    partial void OnBlood_GroupChanged();
    partial void OnMarital_StatusChanging(string value);
    partial void OnMarital_StatusChanged();
    partial void OnMobile_NoChanging(int value);
    partial void OnMobile_NoChanged();
    partial void OnE_MailChanging(string value);
    partial void OnE_MailChanged();
    partial void OnPresent_AddressChanging(string value);
    partial void OnPresent_AddressChanged();
    partial void OnPermanent_AddressChanging(string value);
    partial void OnPermanent_AddressChanged();
    #endregion
		
		public NID_Info1()
		{
			this._Admin = default(EntityRef<Admin>);
			this._Candidate = default(EntityRef<Candidate>);
			this._Voter = default(EntityRef<Voter>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NID
		{
			get
			{
				return this._NID;
			}
			set
			{
				if ((this._NID != value))
				{
					this.OnNIDChanging(value);
					this.SendPropertyChanging();
					this._NID = value;
					this.SendPropertyChanged("NID");
					this.OnNIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Father\'s Name]", Storage="_Father_s_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Father_s_Name
		{
			get
			{
				return this._Father_s_Name;
			}
			set
			{
				if ((this._Father_s_Name != value))
				{
					this.OnFather_s_NameChanging(value);
					this.SendPropertyChanging();
					this._Father_s_Name = value;
					this.SendPropertyChanged("Father_s_Name");
					this.OnFather_s_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Mother\'s Name]", Storage="_Mother_s_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Mother_s_Name
		{
			get
			{
				return this._Mother_s_Name;
			}
			set
			{
				if ((this._Mother_s_Name != value))
				{
					this.OnMother_s_NameChanging(value);
					this.SendPropertyChanging();
					this._Mother_s_Name = value;
					this.SendPropertyChanged("Mother_s_Name");
					this.OnMother_s_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date NOT NULL")]
		public System.DateTime DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Blood Group]", Storage="_Blood_Group", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Blood_Group
		{
			get
			{
				return this._Blood_Group;
			}
			set
			{
				if ((this._Blood_Group != value))
				{
					this.OnBlood_GroupChanging(value);
					this.SendPropertyChanging();
					this._Blood_Group = value;
					this.SendPropertyChanged("Blood_Group");
					this.OnBlood_GroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Marital Status]", Storage="_Marital_Status", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Marital_Status
		{
			get
			{
				return this._Marital_Status;
			}
			set
			{
				if ((this._Marital_Status != value))
				{
					this.OnMarital_StatusChanging(value);
					this.SendPropertyChanging();
					this._Marital_Status = value;
					this.SendPropertyChanged("Marital_Status");
					this.OnMarital_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Mobile No]", Storage="_Mobile_No", DbType="Int NOT NULL")]
		public int Mobile_No
		{
			get
			{
				return this._Mobile_No;
			}
			set
			{
				if ((this._Mobile_No != value))
				{
					this.OnMobile_NoChanging(value);
					this.SendPropertyChanging();
					this._Mobile_No = value;
					this.SendPropertyChanged("Mobile_No");
					this.OnMobile_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[E-Mail]", Storage="_E_Mail", DbType="VarChar(50)")]
		public string E_Mail
		{
			get
			{
				return this._E_Mail;
			}
			set
			{
				if ((this._E_Mail != value))
				{
					this.OnE_MailChanging(value);
					this.SendPropertyChanging();
					this._E_Mail = value;
					this.SendPropertyChanged("E_Mail");
					this.OnE_MailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Present Address]", Storage="_Present_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Present_Address
		{
			get
			{
				return this._Present_Address;
			}
			set
			{
				if ((this._Present_Address != value))
				{
					this.OnPresent_AddressChanging(value);
					this.SendPropertyChanging();
					this._Present_Address = value;
					this.SendPropertyChanged("Present_Address");
					this.OnPresent_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Permanent Address]", Storage="_Permanent_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Permanent_Address
		{
			get
			{
				return this._Permanent_Address;
			}
			set
			{
				if ((this._Permanent_Address != value))
				{
					this.OnPermanent_AddressChanging(value);
					this.SendPropertyChanging();
					this._Permanent_Address = value;
					this.SendPropertyChanged("Permanent_Address");
					this.OnPermanent_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NID_Info1_Admin", Storage="_Admin", ThisKey="NID", OtherKey="NID", IsUnique=true, IsForeignKey=false)]
		public Admin Admin
		{
			get
			{
				return this._Admin.Entity;
			}
			set
			{
				Admin previousValue = this._Admin.Entity;
				if (((previousValue != value) 
							|| (this._Admin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Admin.Entity = null;
						previousValue.NID_Info1 = null;
					}
					this._Admin.Entity = value;
					if ((value != null))
					{
						value.NID_Info1 = this;
					}
					this.SendPropertyChanged("Admin");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NID_Info1_Candidate", Storage="_Candidate", ThisKey="NID", OtherKey="NID", IsUnique=true, IsForeignKey=false)]
		public Candidate Candidate
		{
			get
			{
				return this._Candidate.Entity;
			}
			set
			{
				Candidate previousValue = this._Candidate.Entity;
				if (((previousValue != value) 
							|| (this._Candidate.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Candidate.Entity = null;
						previousValue.NID_Info1 = null;
					}
					this._Candidate.Entity = value;
					if ((value != null))
					{
						value.NID_Info1 = this;
					}
					this.SendPropertyChanged("Candidate");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NID_Info1_Voter", Storage="_Voter", ThisKey="NID", OtherKey="NID", IsUnique=true, IsForeignKey=false)]
		public Voter Voter
		{
			get
			{
				return this._Voter.Entity;
			}
			set
			{
				Voter previousValue = this._Voter.Entity;
				if (((previousValue != value) 
							|| (this._Voter.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Voter.Entity = null;
						previousValue.NID_Info1 = null;
					}
					this._Voter.Entity = value;
					if ((value != null))
					{
						value.NID_Info1 = this;
					}
					this.SendPropertyChanged("Voter");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Voter")]
	public partial class Voter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NID;
		
		private string _Password;
		
		private int _Voting_Status;
		
		private EntityRef<NID_Info1> _NID_Info1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNIDChanging(string value);
    partial void OnNIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnVoting_StatusChanging(int value);
    partial void OnVoting_StatusChanged();
    #endregion
		
		public Voter()
		{
			this._NID_Info1 = default(EntityRef<NID_Info1>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NID
		{
			get
			{
				return this._NID;
			}
			set
			{
				if ((this._NID != value))
				{
					if (this._NID_Info1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNIDChanging(value);
					this.SendPropertyChanging();
					this._NID = value;
					this.SendPropertyChanged("NID");
					this.OnNIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Voting Status]", Storage="_Voting_Status", DbType="Int NOT NULL")]
		public int Voting_Status
		{
			get
			{
				return this._Voting_Status;
			}
			set
			{
				if ((this._Voting_Status != value))
				{
					this.OnVoting_StatusChanging(value);
					this.SendPropertyChanging();
					this._Voting_Status = value;
					this.SendPropertyChanged("Voting_Status");
					this.OnVoting_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NID_Info1_Voter", Storage="_NID_Info1", ThisKey="NID", OtherKey="NID", IsForeignKey=true)]
		public NID_Info1 NID_Info1
		{
			get
			{
				return this._NID_Info1.Entity;
			}
			set
			{
				NID_Info1 previousValue = this._NID_Info1.Entity;
				if (((previousValue != value) 
							|| (this._NID_Info1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NID_Info1.Entity = null;
						previousValue.Voter = null;
					}
					this._NID_Info1.Entity = value;
					if ((value != null))
					{
						value.Voter = this;
						this._NID = value.NID;
					}
					else
					{
						this._NID = default(string);
					}
					this.SendPropertyChanged("NID_Info1");
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
}
#pragma warning restore 1591