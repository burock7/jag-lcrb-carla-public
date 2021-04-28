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
    /// Extension methods for Areaid.
    /// </summary>
    public static partial class AreaidExtensions
    {
            /// <summary>
            /// Get adoxio_AreaId from adoxio_investigationrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInvestigationrequestid'>
            /// key: adoxio_investigationrequestid of adoxio_investigationrequest
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioArea Get(this IAreaid operations, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioInvestigationrequestid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_AreaId from adoxio_investigationrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInvestigationrequestid'>
            /// key: adoxio_investigationrequestid of adoxio_investigationrequest
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
            public static async Task<MicrosoftDynamicsCRMadoxioArea> GetAsync(this IAreaid operations, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioInvestigationrequestid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_AreaId from adoxio_investigationrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInvestigationrequestid'>
            /// key: adoxio_investigationrequestid of adoxio_investigationrequest
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioArea> GetWithHttpMessages(this IAreaid operations, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioInvestigationrequestid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_AreaId from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioArea Get1(this IAreaid operations, string adoxioSpecialeventid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get1Async(adoxioSpecialeventid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_AreaId from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
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
            public static async Task<MicrosoftDynamicsCRMadoxioArea> Get1Async(this IAreaid operations, string adoxioSpecialeventid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get1WithHttpMessagesAsync(adoxioSpecialeventid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_AreaId from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioArea> Get1WithHttpMessages(this IAreaid operations, string adoxioSpecialeventid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.Get1WithHttpMessagesAsync(adoxioSpecialeventid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
