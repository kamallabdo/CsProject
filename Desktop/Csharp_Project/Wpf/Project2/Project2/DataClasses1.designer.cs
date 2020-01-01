﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_ETUDIANT")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertetudiant(etudiant instance);
    partial void Updateetudiant(etudiant instance);
    partial void Deleteetudiant(etudiant instance);
    partial void InsertLogin(Login instance);
    partial void UpdateLogin(Login instance);
    partial void DeleteLogin(Login instance);
    partial void InsertFiliere(Filiere instance);
    partial void UpdateFiliere(Filiere instance);
    partial void DeleteFiliere(Filiere instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Project2.Properties.Settings.Default.DB_ETUDIANTConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<etudiant> etudiant
		{
			get
			{
				return this.GetTable<etudiant>();
			}
		}
		
		public System.Data.Linq.Table<Login> Login
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
		
		public System.Data.Linq.Table<Filiere> Filiere
		{
			get
			{
				return this.GetTable<Filiere>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.etudiant")]
	public partial class etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cne;
		
		private string _nom;
		
		private string _prenom;
		
		private System.Nullable<char> _sexe;
		
		private System.Nullable<System.DateTime> _date_naiss;
		
		private System.Nullable<int> _id_fil;
		
		private System.Data.Linq.Binary _image_etud;
		
		private EntityRef<Filiere> _Filiere;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncneChanging(int value);
    partial void OncneChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OnsexeChanging(System.Nullable<char> value);
    partial void OnsexeChanged();
    partial void Ondate_naissChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_naissChanged();
    partial void Onid_filChanging(System.Nullable<int> value);
    partial void Onid_filChanged();
    partial void Onimage_etudChanging(System.Data.Linq.Binary value);
    partial void Onimage_etudChanged();
    #endregion
		
		public etudiant()
		{
			this._Filiere = default(EntityRef<Filiere>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cne", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cne
		{
			get
			{
				return this._cne;
			}
			set
			{
				if ((this._cne != value))
				{
					this.OncneChanging(value);
					this.SendPropertyChanging();
					this._cne = value;
					this.SendPropertyChanged("cne");
					this.OncneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(100)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(100)")]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexe", DbType="Char(1)")]
		public System.Nullable<char> sexe
		{
			get
			{
				return this._sexe;
			}
			set
			{
				if ((this._sexe != value))
				{
					this.OnsexeChanging(value);
					this.SendPropertyChanging();
					this._sexe = value;
					this.SendPropertyChanged("sexe");
					this.OnsexeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_naiss", DbType="Date")]
		public System.Nullable<System.DateTime> date_naiss
		{
			get
			{
				return this._date_naiss;
			}
			set
			{
				if ((this._date_naiss != value))
				{
					this.Ondate_naissChanging(value);
					this.SendPropertyChanging();
					this._date_naiss = value;
					this.SendPropertyChanged("date_naiss");
					this.Ondate_naissChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_fil", DbType="Int")]
		public System.Nullable<int> id_fil
		{
			get
			{
				return this._id_fil;
			}
			set
			{
				if ((this._id_fil != value))
				{
					if (this._Filiere.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_filChanging(value);
					this.SendPropertyChanging();
					this._id_fil = value;
					this.SendPropertyChanged("id_fil");
					this.Onid_filChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image_etud", DbType="VarBinary(50)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary image_etud
		{
			get
			{
				return this._image_etud;
			}
			set
			{
				if ((this._image_etud != value))
				{
					this.Onimage_etudChanging(value);
					this.SendPropertyChanging();
					this._image_etud = value;
					this.SendPropertyChanged("image_etud");
					this.Onimage_etudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Filiere_etudiant", Storage="_Filiere", ThisKey="id_fil", OtherKey="Id_filiere", IsForeignKey=true, DeleteRule="CASCADE")]
		public Filiere Filiere
		{
			get
			{
				return this._Filiere.Entity;
			}
			set
			{
				Filiere previousValue = this._Filiere.Entity;
				if (((previousValue != value) 
							|| (this._Filiere.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Filiere.Entity = null;
						previousValue.etudiant.Remove(this);
					}
					this._Filiere.Entity = value;
					if ((value != null))
					{
						value.etudiant.Add(this);
						this._id_fil = value.Id_filiere;
					}
					else
					{
						this._id_fil = default(Nullable<int>);
					}
					this.SendPropertyChanged("Filiere");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login")]
	public partial class Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _User;
		
		private string _Password;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Login()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="NChar(10)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10)")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Filiere")]
	public partial class Filiere : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_filiere;
		
		private string _Nom_filiere;
		
		private string _Resp_filiere;
		
		private EntitySet<etudiant> _etudiant;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_filiereChanging(int value);
    partial void OnId_filiereChanged();
    partial void OnNom_filiereChanging(string value);
    partial void OnNom_filiereChanged();
    partial void OnResp_filiereChanging(string value);
    partial void OnResp_filiereChanged();
    #endregion
		
		public Filiere()
		{
			this._etudiant = new EntitySet<etudiant>(new Action<etudiant>(this.attach_etudiant), new Action<etudiant>(this.detach_etudiant));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_filiere", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_filiere
		{
			get
			{
				return this._Id_filiere;
			}
			set
			{
				if ((this._Id_filiere != value))
				{
					this.OnId_filiereChanging(value);
					this.SendPropertyChanging();
					this._Id_filiere = value;
					this.SendPropertyChanged("Id_filiere");
					this.OnId_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom_filiere", DbType="VarChar(100)")]
		public string Nom_filiere
		{
			get
			{
				return this._Nom_filiere;
			}
			set
			{
				if ((this._Nom_filiere != value))
				{
					this.OnNom_filiereChanging(value);
					this.SendPropertyChanging();
					this._Nom_filiere = value;
					this.SendPropertyChanged("Nom_filiere");
					this.OnNom_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resp_filiere", DbType="NChar(40)")]
		public string Resp_filiere
		{
			get
			{
				return this._Resp_filiere;
			}
			set
			{
				if ((this._Resp_filiere != value))
				{
					this.OnResp_filiereChanging(value);
					this.SendPropertyChanging();
					this._Resp_filiere = value;
					this.SendPropertyChanged("Resp_filiere");
					this.OnResp_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Filiere_etudiant", Storage="_etudiant", ThisKey="Id_filiere", OtherKey="id_fil")]
		public EntitySet<etudiant> etudiant
		{
			get
			{
				return this._etudiant;
			}
			set
			{
				this._etudiant.Assign(value);
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
		
		private void attach_etudiant(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.Filiere = this;
		}
		
		private void detach_etudiant(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.Filiere = null;
		}
	}
}
#pragma warning restore 1591
