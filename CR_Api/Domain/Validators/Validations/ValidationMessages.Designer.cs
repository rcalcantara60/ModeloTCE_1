﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Validators.Validations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ValidationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Domain.Validators.Validations.ValidationMessages", typeof(ValidationMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data Inicial deve ser Menor do que a data Final..
        /// </summary>
        internal static string DataFinalMenorInicial {
            get {
                return ResourceManager.GetString("DataFinalMenorInicial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O título do JOB é o tamanho estão incorretos..
        /// </summary>
        internal static string JobIdAndMaxLenghtError {
            get {
                return ResourceManager.GetString("JobIdAndMaxLenghtError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O id do JOB é obrigatório..
        /// </summary>
        internal static string JobIdRequired {
            get {
                return ResourceManager.GetString("JobIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O salário MAX deve ser maior que o MIN..
        /// </summary>
        internal static string JobSalaryMaxMin {
            get {
                return ResourceManager.GetString("JobSalaryMaxMin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O título do JOB é obrigatório..
        /// </summary>
        internal static string JobTitleObrigatorio {
            get {
                return ResourceManager.GetString("JobTitleObrigatorio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {PropertyName} não pode ser nulo ao editar..
        /// </summary>
        internal static string NaoNuloEdit {
            get {
                return ResourceManager.GetString("NaoNuloEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {PropertyName} não pode ser nulo ao inserir..
        /// </summary>
        internal static string NaoNuloInsert {
            get {
                return ResourceManager.GetString("NaoNuloInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O registro com chave {0} já existe..
        /// </summary>
        internal static string ObjetoRepetido {
            get {
                return ResourceManager.GetString("ObjetoRepetido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pessoa não existe..
        /// </summary>
        internal static string PessoaNaoExiste {
            get {
                return ResourceManager.GetString("PessoaNaoExiste", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O Campo  {PropertyName} deve ter no máximo {MaxLength} caracteres..
        /// </summary>
        internal static string TamanhoMaximo {
            get {
                return ResourceManager.GetString("TamanhoMaximo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O Campo  {PropertyName} deve ter no máximo {MinLength} caracteres..
        /// </summary>
        internal static string TamanhoMinimo {
            get {
                return ResourceManager.GetString("TamanhoMinimo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O Campo  {PropertyName} excedeu o tamanhao máximo permitido..
        /// </summary>
        internal static string ValorMaximo {
            get {
                return ResourceManager.GetString("ValorMaximo", resourceCulture);
            }
        }
    }
}
