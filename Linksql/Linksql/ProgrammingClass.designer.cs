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

namespace Linksql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tpcrud")]
	public partial class ProgrammingClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertproductinfo_table(productinfo_table instance);
    partial void Updateproductinfo_table(productinfo_table instance);
    partial void Deleteproductinfo_table(productinfo_table instance);
    #endregion
		
		public ProgrammingClassDataContext() : 
				base(global::Linksql.Properties.Settings.Default.tpcrudConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<productinfo_table> productinfo_tables
		{
			get
			{
				return this.GetTable<productinfo_table>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.productinfo_table")]
	public partial class productinfo_table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _designation;
		
		private string _color;
		
		private System.Nullable<System.DateTime> _insertdate;
		
		private System.Nullable<System.DateTime> _updatedate;
		
		private System.Nullable<System.DateTime> _expiredate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndesignationChanging(string value);
    partial void OndesignationChanged();
    partial void OncolorChanging(string value);
    partial void OncolorChanged();
    partial void OninsertdateChanging(System.Nullable<System.DateTime> value);
    partial void OninsertdateChanged();
    partial void OnupdatedateChanging(System.Nullable<System.DateTime> value);
    partial void OnupdatedateChanged();
    partial void OnexpiredateChanging(System.Nullable<System.DateTime> value);
    partial void OnexpiredateChanged();
    #endregion
		
		public productinfo_table()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_designation", DbType="NVarChar(150)")]
		public string designation
		{
			get
			{
				return this._designation;
			}
			set
			{
				if ((this._designation != value))
				{
					this.OndesignationChanging(value);
					this.SendPropertyChanging();
					this._designation = value;
					this.SendPropertyChanged("designation");
					this.OndesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_color", DbType="NVarChar(50)")]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				if ((this._color != value))
				{
					this.OncolorChanging(value);
					this.SendPropertyChanging();
					this._color = value;
					this.SendPropertyChanged("color");
					this.OncolorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_insertdate", DbType="DateTime")]
		public System.Nullable<System.DateTime> insertdate
		{
			get
			{
				return this._insertdate;
			}
			set
			{
				if ((this._insertdate != value))
				{
					this.OninsertdateChanging(value);
					this.SendPropertyChanging();
					this._insertdate = value;
					this.SendPropertyChanged("insertdate");
					this.OninsertdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updatedate", DbType="DateTime")]
		public System.Nullable<System.DateTime> updatedate
		{
			get
			{
				return this._updatedate;
			}
			set
			{
				if ((this._updatedate != value))
				{
					this.OnupdatedateChanging(value);
					this.SendPropertyChanging();
					this._updatedate = value;
					this.SendPropertyChanged("updatedate");
					this.OnupdatedateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expiredate", DbType="DateTime")]
		public System.Nullable<System.DateTime> expiredate
		{
			get
			{
				return this._expiredate;
			}
			set
			{
				if ((this._expiredate != value))
				{
					this.OnexpiredateChanging(value);
					this.SendPropertyChanging();
					this._expiredate = value;
					this.SendPropertyChanged("expiredate");
					this.OnexpiredateChanged();
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
