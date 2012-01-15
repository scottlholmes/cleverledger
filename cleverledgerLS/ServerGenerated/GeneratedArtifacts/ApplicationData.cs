//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ApplicationData.Implementation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ApplicationDataObjectContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ApplicationDataObjectContext object using the connection string found in the 'ApplicationDataObjectContext' section of the application configuration file.
        /// </summary>
        public ApplicationDataObjectContext() : base("name=ApplicationDataObjectContext", "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationDataObjectContext object.
        /// </summary>
        public ApplicationDataObjectContext(string connectionString) : base(connectionString, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationDataObjectContext object.
        /// </summary>
        public ApplicationDataObjectContext(EntityConnection connection) : base(connection, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Principal> Principals
        {
            get
            {
                if ((_Principals == null))
                {
                    _Principals = base.CreateObjectSet<Principal>("Principals");
                }
                return _Principals;
            }
        }
        private ObjectSet<Principal> _Principals;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Principals EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPrincipals(Principal principal)
        {
            base.AddObject("Principals", principal);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ApplicationData", Name="Principal")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Principal : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Principal object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="principalName">Initial value of the PrincipalName property.</param>
        /// <param name="emailAddress">Initial value of the EmailAddress property.</param>
        public static Principal CreatePrincipal(global::System.Int32 id, global::System.String principalName, global::System.String emailAddress)
        {
            Principal principal = new Principal();
            principal.Id = id;
            principal.PrincipalName = principalName;
            principal.EmailAddress = emailAddress;
            return principal;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PrincipalName
        {
            get
            {
                return _PrincipalName;
            }
            set
            {
                OnPrincipalNameChanging(value);
                ReportPropertyChanging("PrincipalName");
                _PrincipalName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PrincipalName");
                OnPrincipalNameChanged();
            }
        }
        private global::System.String _PrincipalName;
        partial void OnPrincipalNameChanging(global::System.String value);
        partial void OnPrincipalNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();

        #endregion
    
    }

    #endregion
    
}
