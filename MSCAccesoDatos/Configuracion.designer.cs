﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSCAccesoDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="COLEGIOS")]
	public partial class ConfiguracionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCF_COLEGIO(CF_COLEGIO instance);
    partial void UpdateCF_COLEGIO(CF_COLEGIO instance);
    partial void DeleteCF_COLEGIO(CF_COLEGIO instance);
    partial void InsertCF_SUCURSAL(CF_SUCURSAL instance);
    partial void UpdateCF_SUCURSAL(CF_SUCURSAL instance);
    partial void DeleteCF_SUCURSAL(CF_SUCURSAL instance);
    #endregion
		
		public ConfiguracionDataContext() : 
				base(global::MSCAccesoDatos.Properties.Settings.Default.COLEGIOSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConfiguracionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConfiguracionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConfiguracionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConfiguracionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CF_COLEGIO> CF_COLEGIOs
		{
			get
			{
				return this.GetTable<CF_COLEGIO>();
			}
		}
		
		public System.Data.Linq.Table<CF_SUCURSAL> CF_SUCURSALs
		{
			get
			{
				return this.GetTable<CF_SUCURSAL>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CF_COLEGIO")]
	public partial class CF_COLEGIO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CL_ID;
		
		private string _CL_NOMBRE;
		
		private string _CL_DIRECCION;
		
		private string _CL_REPRESENTANTE_LEGAL;
		
		private string _CL_TELEFONO;
		
		private System.Nullable<int> _CL_PAIS;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCL_IDChanging(int value);
    partial void OnCL_IDChanged();
    partial void OnCL_NOMBREChanging(string value);
    partial void OnCL_NOMBREChanged();
    partial void OnCL_DIRECCIONChanging(string value);
    partial void OnCL_DIRECCIONChanged();
    partial void OnCL_REPRESENTANTE_LEGALChanging(string value);
    partial void OnCL_REPRESENTANTE_LEGALChanged();
    partial void OnCL_TELEFONOChanging(string value);
    partial void OnCL_TELEFONOChanged();
    partial void OnCL_PAISChanging(System.Nullable<int> value);
    partial void OnCL_PAISChanged();
    #endregion
		
		public CF_COLEGIO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CL_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CL_ID
		{
			get
			{
				return this._CL_ID;
			}
			set
			{
				if ((this._CL_ID != value))
				{
					this.OnCL_IDChanging(value);
					this.SendPropertyChanging();
					this._CL_ID = value;
					this.SendPropertyChanged("CL_ID");
					this.OnCL_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CL_NOMBRE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CL_NOMBRE
		{
			get
			{
				return this._CL_NOMBRE;
			}
			set
			{
				if ((this._CL_NOMBRE != value))
				{
					this.OnCL_NOMBREChanging(value);
					this.SendPropertyChanging();
					this._CL_NOMBRE = value;
					this.SendPropertyChanged("CL_NOMBRE");
					this.OnCL_NOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CL_DIRECCION", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string CL_DIRECCION
		{
			get
			{
				return this._CL_DIRECCION;
			}
			set
			{
				if ((this._CL_DIRECCION != value))
				{
					this.OnCL_DIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._CL_DIRECCION = value;
					this.SendPropertyChanged("CL_DIRECCION");
					this.OnCL_DIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CL_REPRESENTANTE_LEGAL", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string CL_REPRESENTANTE_LEGAL
		{
			get
			{
				return this._CL_REPRESENTANTE_LEGAL;
			}
			set
			{
				if ((this._CL_REPRESENTANTE_LEGAL != value))
				{
					this.OnCL_REPRESENTANTE_LEGALChanging(value);
					this.SendPropertyChanging();
					this._CL_REPRESENTANTE_LEGAL = value;
					this.SendPropertyChanged("CL_REPRESENTANTE_LEGAL");
					this.OnCL_REPRESENTANTE_LEGALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CL_TELEFONO", DbType="VarChar(20)")]
		public string CL_TELEFONO
		{
			get
			{
				return this._CL_TELEFONO;
			}
			set
			{
				if ((this._CL_TELEFONO != value))
				{
					this.OnCL_TELEFONOChanging(value);
					this.SendPropertyChanging();
					this._CL_TELEFONO = value;
					this.SendPropertyChanged("CL_TELEFONO");
					this.OnCL_TELEFONOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CL_PAIS", DbType="Int")]
		public System.Nullable<int> CL_PAIS
		{
			get
			{
				return this._CL_PAIS;
			}
			set
			{
				if ((this._CL_PAIS != value))
				{
					this.OnCL_PAISChanging(value);
					this.SendPropertyChanging();
					this._CL_PAIS = value;
					this.SendPropertyChanged("CL_PAIS");
					this.OnCL_PAISChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CF_SUCURSAL")]
	public partial class CF_SUCURSAL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SU_ID;
		
		private string _SU_NOMBRE;
		
		private string _SU_DIRECCION;
		
		private string _SU_ENCARGADO;
		
		private string _SU_TELEFONO;
		
		private char _SU_ESTADO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSU_IDChanging(int value);
    partial void OnSU_IDChanged();
    partial void OnSU_NOMBREChanging(string value);
    partial void OnSU_NOMBREChanged();
    partial void OnSU_DIRECCIONChanging(string value);
    partial void OnSU_DIRECCIONChanged();
    partial void OnSU_ENCARGADOChanging(string value);
    partial void OnSU_ENCARGADOChanged();
    partial void OnSU_TELEFONOChanging(string value);
    partial void OnSU_TELEFONOChanged();
    partial void OnSU_ESTADOChanging(char value);
    partial void OnSU_ESTADOChanged();
    #endregion
		
		public CF_SUCURSAL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SU_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SU_ID
		{
			get
			{
				return this._SU_ID;
			}
			set
			{
				if ((this._SU_ID != value))
				{
					this.OnSU_IDChanging(value);
					this.SendPropertyChanging();
					this._SU_ID = value;
					this.SendPropertyChanged("SU_ID");
					this.OnSU_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SU_NOMBRE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SU_NOMBRE
		{
			get
			{
				return this._SU_NOMBRE;
			}
			set
			{
				if ((this._SU_NOMBRE != value))
				{
					this.OnSU_NOMBREChanging(value);
					this.SendPropertyChanging();
					this._SU_NOMBRE = value;
					this.SendPropertyChanged("SU_NOMBRE");
					this.OnSU_NOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SU_DIRECCION", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string SU_DIRECCION
		{
			get
			{
				return this._SU_DIRECCION;
			}
			set
			{
				if ((this._SU_DIRECCION != value))
				{
					this.OnSU_DIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._SU_DIRECCION = value;
					this.SendPropertyChanged("SU_DIRECCION");
					this.OnSU_DIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SU_ENCARGADO", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SU_ENCARGADO
		{
			get
			{
				return this._SU_ENCARGADO;
			}
			set
			{
				if ((this._SU_ENCARGADO != value))
				{
					this.OnSU_ENCARGADOChanging(value);
					this.SendPropertyChanging();
					this._SU_ENCARGADO = value;
					this.SendPropertyChanged("SU_ENCARGADO");
					this.OnSU_ENCARGADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SU_TELEFONO", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string SU_TELEFONO
		{
			get
			{
				return this._SU_TELEFONO;
			}
			set
			{
				if ((this._SU_TELEFONO != value))
				{
					this.OnSU_TELEFONOChanging(value);
					this.SendPropertyChanging();
					this._SU_TELEFONO = value;
					this.SendPropertyChanged("SU_TELEFONO");
					this.OnSU_TELEFONOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SU_ESTADO", DbType="Char(1) NOT NULL")]
		public char SU_ESTADO
		{
			get
			{
				return this._SU_ESTADO;
			}
			set
			{
				if ((this._SU_ESTADO != value))
				{
					this.OnSU_ESTADOChanging(value);
					this.SendPropertyChanging();
					this._SU_ESTADO = value;
					this.SendPropertyChanged("SU_ESTADO");
					this.OnSU_ESTADOChanged();
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
