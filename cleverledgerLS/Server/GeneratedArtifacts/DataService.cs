//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    public sealed partial class ApplicationDataService
        : global::LightSwitchApplication.ApplicationData
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ApplicationDataService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Inserting(global::LightSwitchApplication.Principal entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Inserted(global::LightSwitchApplication.Principal entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Updating(global::LightSwitchApplication.Principal entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Updated(global::LightSwitchApplication.Principal entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Deleting(global::LightSwitchApplication.Principal entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Deleted(global::LightSwitchApplication.Principal entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Validate(global::LightSwitchApplication.Principal entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Single_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Single_Executing(global::System.Nullable<int> Id);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Single_PreprocessQuery(global::System.Nullable<int> Id, ref global::System.Linq.IQueryable<global::LightSwitchApplication.Principal> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Single_Executed(global::System.Nullable<int> Id, global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Principal> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_Single_ExecuteFailed(global::System.Nullable<int> Id, global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_SingleOrDefault_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_SingleOrDefault_Executing(global::System.Nullable<int> Id);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_SingleOrDefault_PreprocessQuery(global::System.Nullable<int> Id, ref global::System.Linq.IQueryable<global::LightSwitchApplication.Principal> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_SingleOrDefault_Executed(global::System.Nullable<int> Id, global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Principal> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_SingleOrDefault_ExecuteFailed(global::System.Nullable<int> Id, global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_All_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_All_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_All_PreprocessQuery(ref global::System.Linq.IQueryable<global::LightSwitchApplication.Principal> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_All_Executed(global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Principal> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Principals_All_ExecuteFailed(global::System.Exception exception);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>
                __PrincipalsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>(
                    "Principals",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Validate);
            private static bool __Principals_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Principals_CanInsert(ref result);
                return result;
            }
            private static bool __Principals_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Principals_CanUpdate(ref result);
                return result;
            }
            private static bool __Principals_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Principals_CanDelete(ref result);
                return result;
            }
            private static bool __Principals_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Principals_CanRead(ref result);
                return result;
            }
            private static void __Principals_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Principal e)
            {
                d.Principals_Inserting(e);
            }
            private static void __Principals_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Principal e)
            {
                d.Principals_Inserted(e);
            }
            private static void __Principals_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Principal e)
            {
                d.Principals_Updating(e);
            }
            private static void __Principals_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Principal e)
            {
                d.Principals_Updated(e);
            }
            private static void __Principals_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Principal e)
            {
                d.Principals_Deleting(e);
            }
            private static void __Principals_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Principal e)
            {
                d.Principals_Deleted(e);
            }
            private static void __Principals_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Principal e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Principals_Validate(e, r);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>(
                    "SaveChanges",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>
                __Principals_SingleEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>(
                    "Principals_Single",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Single_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Single_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Single_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Single_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_Single_PreprocessQuery);
            private static bool __Principals_Single_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.Principals_Single_CanExecute(ref r);
                return r;
            }
            private static void __Principals_Single_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Principals_Single_Executing((global::System.Nullable<int>)args[0]);
            }
            private static void __Principals_Single_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Principals_Single_Executed((global::System.Nullable<int>)args[0], (global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Principal>)args[1]);
            }
            private static void __Principals_Single_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.Principals_Single_ExecuteFailed((global::System.Nullable<int>)args[0], ex);
            }
            private static global::System.Linq.IQueryable __Principals_Single_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Principal> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Principal>)args[1];
                d.Principals_Single_PreprocessQuery((global::System.Nullable<int>)args[0], ref query);
                return query;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>
                __Principals_SingleOrDefaultEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>(
                    "Principals_SingleOrDefault",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_SingleOrDefault_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_SingleOrDefault_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_SingleOrDefault_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_SingleOrDefault_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_SingleOrDefault_PreprocessQuery);
            private static bool __Principals_SingleOrDefault_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.Principals_SingleOrDefault_CanExecute(ref r);
                return r;
            }
            private static void __Principals_SingleOrDefault_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Principals_SingleOrDefault_Executing((global::System.Nullable<int>)args[0]);
            }
            private static void __Principals_SingleOrDefault_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Principals_SingleOrDefault_Executed((global::System.Nullable<int>)args[0], (global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Principal>)args[1]);
            }
            private static void __Principals_SingleOrDefault_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.Principals_SingleOrDefault_ExecuteFailed((global::System.Nullable<int>)args[0], ex);
            }
            private static global::System.Linq.IQueryable __Principals_SingleOrDefault_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Principal> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Principal>)args[1];
                d.Principals_SingleOrDefault_PreprocessQuery((global::System.Nullable<int>)args[0], ref query);
                return query;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>
                __Principals_AllEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Principal>(
                    "Principals_All",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_All_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_All_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_All_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_All_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Principals_All_PreprocessQuery);
            private static bool __Principals_All_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.Principals_All_CanExecute(ref r);
                return r;
            }
            private static void __Principals_All_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Principals_All_Executing();
            }
            private static void __Principals_All_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.Principals_All_Executed((global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Principal>)args[0]);
            }
            private static void __Principals_All_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.Principals_All_ExecuteFailed(ex);
            }
            private static global::System.Linq.IQueryable __Principals_All_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Principal> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Principal>)args[0];
                d.Principals_All_PreprocessQuery(ref query);
                return query;
            }
    
        }
    
        #endregion
    }
    
    #endregion
}
