// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Contraventionsharepointdocumentlocations.
    /// </summary>
    public static partial class ContraventionsharepointdocumentlocationsExtensions
    {
            /// <summary>
            /// Get adoxio_contravention_SharePointDocumentLocations from
            /// adoxio_contraventions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionid'>
            /// key: adoxio_contraventionid of adoxio_contravention
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMsharepointdocumentlocationCollection Get(this IContraventionsharepointdocumentlocations operations, string adoxioContraventionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioContraventionid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_contravention_SharePointDocumentLocations from
            /// adoxio_contraventions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionid'>
            /// key: adoxio_contraventionid of adoxio_contravention
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMsharepointdocumentlocationCollection> GetAsync(this IContraventionsharepointdocumentlocations operations, string adoxioContraventionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioContraventionid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_contravention_SharePointDocumentLocations from
            /// adoxio_contraventions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionid'>
            /// key: adoxio_contraventionid of adoxio_contravention
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMsharepointdocumentlocationCollection> GetWithHttpMessages(this IContraventionsharepointdocumentlocations operations, string adoxioContraventionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioContraventionid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_contravention_SharePointDocumentLocations from
            /// adoxio_contraventions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionid'>
            /// key: adoxio_contraventionid of adoxio_contravention
            /// </param>
            /// <param name='sharepointdocumentlocationid'>
            /// key: sharepointdocumentlocationid of sharepointdocumentlocation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMsharepointdocumentlocation SharePointDocumentLocationsByKey(this IContraventionsharepointdocumentlocations operations, string adoxioContraventionid, string sharepointdocumentlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.SharePointDocumentLocationsByKeyAsync(adoxioContraventionid, sharepointdocumentlocationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_contravention_SharePointDocumentLocations from
            /// adoxio_contraventions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionid'>
            /// key: adoxio_contraventionid of adoxio_contravention
            /// </param>
            /// <param name='sharepointdocumentlocationid'>
            /// key: sharepointdocumentlocationid of sharepointdocumentlocation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMsharepointdocumentlocation> SharePointDocumentLocationsByKeyAsync(this IContraventionsharepointdocumentlocations operations, string adoxioContraventionid, string sharepointdocumentlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SharePointDocumentLocationsByKeyWithHttpMessagesAsync(adoxioContraventionid, sharepointdocumentlocationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_contravention_SharePointDocumentLocations from
            /// adoxio_contraventions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionid'>
            /// key: adoxio_contraventionid of adoxio_contravention
            /// </param>
            /// <param name='sharepointdocumentlocationid'>
            /// key: sharepointdocumentlocationid of sharepointdocumentlocation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMsharepointdocumentlocation> SharePointDocumentLocationsByKeyWithHttpMessages(this IContraventionsharepointdocumentlocations operations, string adoxioContraventionid, string sharepointdocumentlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.SharePointDocumentLocationsByKeyWithHttpMessagesAsync(adoxioContraventionid, sharepointdocumentlocationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}