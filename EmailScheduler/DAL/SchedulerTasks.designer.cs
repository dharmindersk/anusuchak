﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailScheduler.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Anusuchak")]
	public partial class SchedulerTasksDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertTask(Task instance);
    partial void UpdateTask(Task instance);
    partial void DeleteTask(Task instance);
    #endregion
		
		public SchedulerTasksDataContext() : 
				base(global::EmailScheduler.Properties.Settings.Default.AnusuchakConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerTasksDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerTasksDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerTasksDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerTasksDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Attribute> Attributes
		{
			get
			{
				return this.GetTable<Attribute>();
			}
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Task> Tasks
		{
			get
			{
				return this.GetTable<Task>();
			}
		}
		
		public System.Data.Linq.Table<UserSession> UserSessions
		{
			get
			{
				return this.GetTable<UserSession>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spCreateUserSession")]
		public int spCreateUserSession([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string session_data, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string api_key)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, session_data, api_key);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spUpdateTasks")]
		public int spUpdateTasks([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string owner, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tasktype, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string status, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> scheduled_time, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string frequency)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, owner, tasktype, title, status, scheduled_time, frequency);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spDeleteAccount")]
		public int spDeleteAccount([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spDeleteByTasksOwner")]
		public int spDeleteByTasksOwner([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string owner)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), owner);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spDeleteTasks")]
		public int spDeleteTasks([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spDeleteUserSession")]
		public int spDeleteUserSession([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertAccount")]
		public ISingleResult<spInsertAccountResult> spInsertAccount([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> enabled)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, email, enabled);
			return ((ISingleResult<spInsertAccountResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertAttributes")]
		public int spInsertAttributes([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> task_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string attr_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(512)")] string attr_value)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), task_id, attr_name, attr_value);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertTasks")]
		public int spInsertTasks([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string owner, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tasktype, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string status, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> scheduled_time, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string frequency)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), owner, tasktype, title, status, scheduled_time, frequency);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSelectAllAccount")]
		public ISingleResult<spSelectAllAccountResult> spSelectAllAccount()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<spSelectAllAccountResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSelectAllTasks")]
		public ISingleResult<spSelectAllTasksResult> spSelectAllTasks()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<spSelectAllTasksResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSelectByAttributesTask_id")]
		public ISingleResult<spSelectByAttributesTask_idResult> spSelectByAttributesTask_id([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> task_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), task_id);
			return ((ISingleResult<spSelectByAttributesTask_idResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSelectByTasksOwner")]
		public ISingleResult<spSelectByTasksOwnerResult> spSelectByTasksOwner([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string owner)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), owner);
			return ((ISingleResult<spSelectByTasksOwnerResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSelectSingleAccount")]
		public ISingleResult<spSelectSingleAccountResult> spSelectSingleAccount([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username);
			return ((ISingleResult<spSelectSingleAccountResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spUpdateAccount")]
		public int spUpdateAccount([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> enabled)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, username, password, email, enabled);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spUpdateByTasksOwner")]
		public int spUpdateByTasksOwner([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string owner, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tasktype, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string status, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> scheduled_time, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string frequency)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), owner, tasktype, title, status, scheduled_time, frequency);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSelectAccountByApiKey")]
		public ISingleResult<spSelectAccountByApiKeyResult> spSelectAccountByApiKey([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string apikey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), apikey);
			return ((ISingleResult<spSelectAccountByApiKeyResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Attributes")]
	public partial class Attribute
	{
		
		private long _task_id;
		
		private string _attr_name;
		
		private string _attr_value;
		
		public Attribute()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_task_id", DbType="BigInt NOT NULL")]
		public long task_id
		{
			get
			{
				return this._task_id;
			}
			set
			{
				if ((this._task_id != value))
				{
					this._task_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_attr_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string attr_name
		{
			get
			{
				return this._attr_name;
			}
			set
			{
				if ((this._attr_name != value))
				{
					this._attr_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_attr_value", DbType="NVarChar(512) NOT NULL", CanBeNull=false)]
		public string attr_value
		{
			get
			{
				return this._attr_value;
			}
			set
			{
				if ((this._attr_value != value))
				{
					this._attr_value = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _username;
		
		private string _password;
		
		private string _email;
		
		private bool _enabled;
		
		private System.DateTime _added_on;
		
		private EntitySet<Task> _Tasks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnenabledChanging(bool value);
    partial void OnenabledChanged();
    partial void Onadded_onChanging(System.DateTime value);
    partial void Onadded_onChanged();
    #endregion
		
		public Account()
		{
			this._Tasks = new EntitySet<Task>(new Action<Task>(this.attach_Tasks), new Action<Task>(this.detach_Tasks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="BigInt NOT NULL IDENTITY", IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enabled", DbType="Bit NOT NULL")]
		public bool enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if ((this._enabled != value))
				{
					this.OnenabledChanging(value);
					this.SendPropertyChanging();
					this._enabled = value;
					this.SendPropertyChanged("enabled");
					this.OnenabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_added_on", DbType="DateTime NOT NULL")]
		public System.DateTime added_on
		{
			get
			{
				return this._added_on;
			}
			set
			{
				if ((this._added_on != value))
				{
					this.Onadded_onChanging(value);
					this.SendPropertyChanging();
					this._added_on = value;
					this.SendPropertyChanged("added_on");
					this.Onadded_onChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Task", Storage="_Tasks", ThisKey="username", OtherKey="owner")]
		public EntitySet<Task> Tasks
		{
			get
			{
				return this._Tasks;
			}
			set
			{
				this._Tasks.Assign(value);
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
		
		private void attach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tasks")]
	public partial class Task : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _owner;
		
		private string _tasktype;
		
		private string _title;
		
		private string _status;
		
		private System.DateTime _scheduled_time;
		
		private string _frequency;
		
		private System.DateTime _added_on;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnownerChanging(string value);
    partial void OnownerChanged();
    partial void OntasktypeChanging(string value);
    partial void OntasktypeChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void Onscheduled_timeChanging(System.DateTime value);
    partial void Onscheduled_timeChanged();
    partial void OnfrequencyChanging(string value);
    partial void OnfrequencyChanged();
    partial void Onadded_onChanging(System.DateTime value);
    partial void Onadded_onChanged();
    #endregion
		
		public Task()
		{
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_owner", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				if ((this._owner != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnownerChanging(value);
					this.SendPropertyChanging();
					this._owner = value;
					this.SendPropertyChanged("owner");
					this.OnownerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tasktype", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tasktype
		{
			get
			{
				return this._tasktype;
			}
			set
			{
				if ((this._tasktype != value))
				{
					this.OntasktypeChanging(value);
					this.SendPropertyChanging();
					this._tasktype = value;
					this.SendPropertyChanged("tasktype");
					this.OntasktypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scheduled_time", DbType="DateTime NOT NULL")]
		public System.DateTime scheduled_time
		{
			get
			{
				return this._scheduled_time;
			}
			set
			{
				if ((this._scheduled_time != value))
				{
					this.Onscheduled_timeChanging(value);
					this.SendPropertyChanging();
					this._scheduled_time = value;
					this.SendPropertyChanged("scheduled_time");
					this.Onscheduled_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_frequency", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string frequency
		{
			get
			{
				return this._frequency;
			}
			set
			{
				if ((this._frequency != value))
				{
					this.OnfrequencyChanging(value);
					this.SendPropertyChanging();
					this._frequency = value;
					this.SendPropertyChanged("frequency");
					this.OnfrequencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_added_on", DbType="DateTime NOT NULL")]
		public System.DateTime added_on
		{
			get
			{
				return this._added_on;
			}
			set
			{
				if ((this._added_on != value))
				{
					this.Onadded_onChanging(value);
					this.SendPropertyChanging();
					this._added_on = value;
					this.SendPropertyChanged("added_on");
					this.Onadded_onChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Task", Storage="_Account", ThisKey="owner", OtherKey="username", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Tasks.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Tasks.Add(this);
						this._owner = value.username;
					}
					else
					{
						this._owner = default(string);
					}
					this.SendPropertyChanged("Account");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserSession")]
	public partial class UserSession
	{
		
		private string _username;
		
		private string _session_data;
		
		private string _apikey;
		
		private System.DateTime _add_date;
		
		public UserSession()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_session_data", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string session_data
		{
			get
			{
				return this._session_data;
			}
			set
			{
				if ((this._session_data != value))
				{
					this._session_data = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apikey", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string apikey
		{
			get
			{
				return this._apikey;
			}
			set
			{
				if ((this._apikey != value))
				{
					this._apikey = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_add_date", DbType="DateTime NOT NULL")]
		public System.DateTime add_date
		{
			get
			{
				return this._add_date;
			}
			set
			{
				if ((this._add_date != value))
				{
					this._add_date = value;
				}
			}
		}
	}
	
	public partial class spInsertAccountResult
	{
		
		private System.Nullable<decimal> _id;
		
		public spInsertAccountResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
	}
	
	public partial class spSelectAllAccountResult
	{
		
		private long _id;
		
		private string _username;
		
		private string _password;
		
		private string _email;
		
		private bool _enabled;
		
		public spSelectAllAccountResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL")]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enabled", DbType="Bit NOT NULL")]
		public bool enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if ((this._enabled != value))
				{
					this._enabled = value;
				}
			}
		}
	}
	
	public partial class spSelectAllTasksResult
	{
		
		private long _id;
		
		private string _owner;
		
		private string _tasktype;
		
		private string _title;
		
		private string _status;
		
		private System.DateTime _scheduled_time;
		
		private string _frequency;
		
		public spSelectAllTasksResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL")]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_owner", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				if ((this._owner != value))
				{
					this._owner = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tasktype", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tasktype
		{
			get
			{
				return this._tasktype;
			}
			set
			{
				if ((this._tasktype != value))
				{
					this._tasktype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this._title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scheduled_time", DbType="DateTime NOT NULL")]
		public System.DateTime scheduled_time
		{
			get
			{
				return this._scheduled_time;
			}
			set
			{
				if ((this._scheduled_time != value))
				{
					this._scheduled_time = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_frequency", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string frequency
		{
			get
			{
				return this._frequency;
			}
			set
			{
				if ((this._frequency != value))
				{
					this._frequency = value;
				}
			}
		}
	}
	
	public partial class spSelectByAttributesTask_idResult
	{
		
		private long _task_id;
		
		private string _attr_name;
		
		private string _attr_value;
		
		public spSelectByAttributesTask_idResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_task_id", DbType="BigInt NOT NULL")]
		public long task_id
		{
			get
			{
				return this._task_id;
			}
			set
			{
				if ((this._task_id != value))
				{
					this._task_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_attr_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string attr_name
		{
			get
			{
				return this._attr_name;
			}
			set
			{
				if ((this._attr_name != value))
				{
					this._attr_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_attr_value", DbType="NVarChar(512) NOT NULL", CanBeNull=false)]
		public string attr_value
		{
			get
			{
				return this._attr_value;
			}
			set
			{
				if ((this._attr_value != value))
				{
					this._attr_value = value;
				}
			}
		}
	}
	
	public partial class spSelectByTasksOwnerResult
	{
		
		private long _id;
		
		private string _owner;
		
		private string _tasktype;
		
		private string _title;
		
		private string _status;
		
		private System.DateTime _scheduled_time;
		
		private string _frequency;
		
		public spSelectByTasksOwnerResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL")]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_owner", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				if ((this._owner != value))
				{
					this._owner = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tasktype", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tasktype
		{
			get
			{
				return this._tasktype;
			}
			set
			{
				if ((this._tasktype != value))
				{
					this._tasktype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this._title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scheduled_time", DbType="DateTime NOT NULL")]
		public System.DateTime scheduled_time
		{
			get
			{
				return this._scheduled_time;
			}
			set
			{
				if ((this._scheduled_time != value))
				{
					this._scheduled_time = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_frequency", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string frequency
		{
			get
			{
				return this._frequency;
			}
			set
			{
				if ((this._frequency != value))
				{
					this._frequency = value;
				}
			}
		}
	}
	
	public partial class spSelectSingleAccountResult
	{
		
		private long _id;
		
		private string _username;
		
		private string _password;
		
		private string _email;
		
		private bool _enabled;
		
		public spSelectSingleAccountResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL")]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enabled", DbType="Bit NOT NULL")]
		public bool enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if ((this._enabled != value))
				{
					this._enabled = value;
				}
			}
		}
	}
	
	public partial class spSelectAccountByApiKeyResult
	{
		
		private long _id;
		
		private string _username;
		
		private string _password;
		
		private string _email;
		
		private bool _enabled;
		
		public spSelectAccountByApiKeyResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL")]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enabled", DbType="Bit NOT NULL")]
		public bool enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if ((this._enabled != value))
				{
					this._enabled = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
