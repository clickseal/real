﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace real.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="2012074001")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertsms_db(sms_db instance);
    partial void Updatesms_db(sms_db instance);
    partial void Deletesms_db(sms_db instance);
    partial void Insertsms_exam(sms_exam instance);
    partial void Updatesms_exam(sms_exam instance);
    partial void Deletesms_exam(sms_exam instance);
    #endregion
		
		public dbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["_2012074001ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<sms_db> sms_dbs
		{
			get
			{
				return this.GetTable<sms_db>();
			}
		}
		
		public System.Data.Linq.Table<sms_exam> sms_exams
		{
			get
			{
				return this.GetTable<sms_exam>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sms_ExamCreate_2")]
		public int sms_ExamCreate_2([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mobile", DbType="VarChar(8)")] string mobile)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), mobile);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sms_ExamGet")]
		public ISingleResult<sms_ExamGetResult> sms_ExamGet([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string quidVAL)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), quidVAL);
			return ((ISingleResult<sms_ExamGetResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sms_ExamGet_Choice")]
		public ISingleResult<sms_ExamGet_ChoiceResult> sms_ExamGet_Choice([global::System.Data.Linq.Mapping.ParameterAttribute(Name="QuizID", DbType="VarChar(10)")] string quizID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TestID", DbType="Int")] System.Nullable<int> testID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), quizID, testID);
			return ((ISingleResult<sms_ExamGet_ChoiceResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sms_db")]
	public partial class sms_db : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _sms;
		
		private string _mobile;
		
		private System.Nullable<System.DateTime> _ognoo;
		
		private System.Nullable<bool> _is_used;
		
		private string _activation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnsmsChanging(string value);
    partial void OnsmsChanged();
    partial void OnmobileChanging(string value);
    partial void OnmobileChanged();
    partial void OnognooChanging(System.Nullable<System.DateTime> value);
    partial void OnognooChanged();
    partial void Onis_usedChanging(System.Nullable<bool> value);
    partial void Onis_usedChanged();
    partial void OnactivationChanging(string value);
    partial void OnactivationChanged();
    #endregion
		
		public sms_db()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sms", DbType="NVarChar(140)")]
		public string sms
		{
			get
			{
				return this._sms;
			}
			set
			{
				if ((this._sms != value))
				{
					this.OnsmsChanging(value);
					this.SendPropertyChanging();
					this._sms = value;
					this.SendPropertyChanged("sms");
					this.OnsmsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile", DbType="VarChar(8)")]
		public string mobile
		{
			get
			{
				return this._mobile;
			}
			set
			{
				if ((this._mobile != value))
				{
					this.OnmobileChanging(value);
					this.SendPropertyChanging();
					this._mobile = value;
					this.SendPropertyChanged("mobile");
					this.OnmobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ognoo", DbType="DateTime")]
		public System.Nullable<System.DateTime> ognoo
		{
			get
			{
				return this._ognoo;
			}
			set
			{
				if ((this._ognoo != value))
				{
					this.OnognooChanging(value);
					this.SendPropertyChanging();
					this._ognoo = value;
					this.SendPropertyChanged("ognoo");
					this.OnognooChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_is_used", DbType="Bit")]
		public System.Nullable<bool> is_used
		{
			get
			{
				return this._is_used;
			}
			set
			{
				if ((this._is_used != value))
				{
					this.Onis_usedChanging(value);
					this.SendPropertyChanging();
					this._is_used = value;
					this.SendPropertyChanged("is_used");
					this.Onis_usedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activation", DbType="VarChar(6)")]
		public string activation
		{
			get
			{
				return this._activation;
			}
			set
			{
				if ((this._activation != value))
				{
					this.OnactivationChanging(value);
					this.SendPropertyChanging();
					this._activation = value;
					this.SendPropertyChanged("activation");
					this.OnactivationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sms_exams")]
	public partial class sms_exam : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _config;
		
		private System.Nullable<System.DateTime> _ognoo1;
		
		private System.Nullable<System.DateTime> _ognoo2;
		
		private System.Nullable<bool> _is_finished;
		
		private string _mobile;
		
		private string _quidval;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnconfigChanging(string value);
    partial void OnconfigChanged();
    partial void Onognoo1Changing(System.Nullable<System.DateTime> value);
    partial void Onognoo1Changed();
    partial void Onognoo2Changing(System.Nullable<System.DateTime> value);
    partial void Onognoo2Changed();
    partial void Onis_finishedChanging(System.Nullable<bool> value);
    partial void Onis_finishedChanged();
    partial void OnmobileChanging(string value);
    partial void OnmobileChanged();
    partial void OnquidvalChanging(string value);
    partial void OnquidvalChanged();
    #endregion
		
		public sms_exam()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_config", DbType="VarChar(4000)")]
		public string config
		{
			get
			{
				return this._config;
			}
			set
			{
				if ((this._config != value))
				{
					this.OnconfigChanging(value);
					this.SendPropertyChanging();
					this._config = value;
					this.SendPropertyChanged("config");
					this.OnconfigChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ognoo1", DbType="DateTime")]
		public System.Nullable<System.DateTime> ognoo1
		{
			get
			{
				return this._ognoo1;
			}
			set
			{
				if ((this._ognoo1 != value))
				{
					this.Onognoo1Changing(value);
					this.SendPropertyChanging();
					this._ognoo1 = value;
					this.SendPropertyChanged("ognoo1");
					this.Onognoo1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ognoo2", DbType="DateTime")]
		public System.Nullable<System.DateTime> ognoo2
		{
			get
			{
				return this._ognoo2;
			}
			set
			{
				if ((this._ognoo2 != value))
				{
					this.Onognoo2Changing(value);
					this.SendPropertyChanging();
					this._ognoo2 = value;
					this.SendPropertyChanged("ognoo2");
					this.Onognoo2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_is_finished", DbType="Bit")]
		public System.Nullable<bool> is_finished
		{
			get
			{
				return this._is_finished;
			}
			set
			{
				if ((this._is_finished != value))
				{
					this.Onis_finishedChanging(value);
					this.SendPropertyChanging();
					this._is_finished = value;
					this.SendPropertyChanged("is_finished");
					this.Onis_finishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile", DbType="VarChar(8)")]
		public string mobile
		{
			get
			{
				return this._mobile;
			}
			set
			{
				if ((this._mobile != value))
				{
					this.OnmobileChanging(value);
					this.SendPropertyChanging();
					this._mobile = value;
					this.SendPropertyChanged("mobile");
					this.OnmobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quidval", DbType="VarChar(50)")]
		public string quidval
		{
			get
			{
				return this._quidval;
			}
			set
			{
				if ((this._quidval != value))
				{
					this.OnquidvalChanging(value);
					this.SendPropertyChanging();
					this._quidval = value;
					this.SendPropertyChanged("quidval");
					this.OnquidvalChanged();
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
	
	public partial class sms_ExamGetResult
	{
		
		private System.Nullable<int> _id;
		
		private string _title;
		
		public sms_ExamGetResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int")]
		public System.Nullable<int> id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(2000)")]
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
	}
	
	public partial class sms_ExamGet_ChoiceResult
	{
		
		private int _id;
		
		private string _title;
		
		private string _is_true;
		
		public sms_ExamGet_ChoiceResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_is_true", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string is_true
		{
			get
			{
				return this._is_true;
			}
			set
			{
				if ((this._is_true != value))
				{
					this._is_true = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
