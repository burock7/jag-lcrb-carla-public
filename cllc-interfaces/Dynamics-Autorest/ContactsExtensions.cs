// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Contacts.
    /// </summary>
    public static partial class ContactsExtensions
    {
            /// <summary>
            /// Add new entity to contacts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            public static MicrosoftDynamicsCRMcontact Addnewentitytocontacts(this IContacts operations, MicrosoftDynamicsCRMcontact body)
            {
                return operations.AddnewentitytocontactsAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to contacts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMcontact> AddnewentitytocontactsAsync(this IContacts operations, MicrosoftDynamicsCRMcontact body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddnewentitytocontactsWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
