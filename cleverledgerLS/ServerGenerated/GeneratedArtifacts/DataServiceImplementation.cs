//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    
    [global::System.ServiceModel.DomainServices.Hosting.EnableClientAccess()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDomainService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DomainService<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
    
        public ApplicationDataDomainService() : base()
        {
        }
    
    #region Public Methods
    
    #region Principal
    
        public void InsertPrincipal(global::ApplicationData.Implementation.Principal entity)
        {
            if (entity.EntityState != global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, global::System.Data.EntityState.Added);
            }
            else
            {
                this.ObjectContext.Principals.AddObject(entity);
            }
        }
    
        public void UpdatePrincipal(global::ApplicationData.Implementation.Principal currentEntity)
        {
            global::System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(this.ObjectContext.Principals, currentEntity, this.ChangeSet.GetOriginal(currentEntity));
        }
    
        public void DeletePrincipal(global::ApplicationData.Implementation.Principal entity)
        {
            if (entity.EntityState == global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.Principals.Attach(entity);
            }
    
            this.DeleteEntity(entity);
        }
    #endregion
    
    #region Queries
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> Principals_Single(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Principal>("Principals_Single", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> Principals_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Principal>("Principals_SingleOrDefault", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> Principals_All(string frameworkOperators)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Principal>("Principals_All", frameworkOperators);
        }
    
    #endregion
    
        [global::System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects=false)]
        public int __GetEntitySetCanInformation(string entitySetName)
        {
            return base.GetEntitySetCanInformation(entitySetName);
        }
    
        [global::System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects=false)]
        public bool __CanExecuteOperation(string operationName)
        {
            return base.CanExecuteOperation(operationName);
        }
    
    #endregion
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().ApplicationData;
        }
    
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> Principals_Single(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Principal>("Principals_All"),
                (p) => (Id.HasValue && (p.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> Principals_SingleOrDefault(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Principal>("Principals_All"),
                (p) => (Id.HasValue && (p.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> Principals_All()
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Principal> query;
            query = base.CreateQuery<global::ApplicationData.Implementation.Principal>("[Principals]").AsQueryable();
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::ApplicationData.Implementation.Principal))
            {
                return new global::ApplicationData.Implementation.Principal();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::ApplicationData.Implementation.ApplicationDataObjectContext CreateObjectContext()
        {
            return new global::ApplicationData.Implementation.ApplicationDataObjectContext(base.GetEntityConnectionString(
                "_IntrinsicData", 
                "res://*/ApplicationData.csdl|res://*/ApplicationData.ssdl|res://*/ApplicationData.msl",
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Principal))
            {
                return new global::ApplicationData.Implementation.Principal();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Principal) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Principal);
            }
            return null;
        }
    }
}

namespace ApplicationData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Principal :
        global::LightSwitchApplication.Principal.DetailsClass.IImplementation
    {
    
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

