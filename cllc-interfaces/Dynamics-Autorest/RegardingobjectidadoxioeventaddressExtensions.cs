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
    /// Extension methods for Regardingobjectidadoxioeventaddress.
    /// </summary>
    public static partial class RegardingobjectidadoxioeventaddressExtensions
    {
            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from asyncoperations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioEventaddress Get(this IRegardingobjectidadoxioeventaddress operations, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(asyncoperationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from asyncoperations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
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
            public static async Task<MicrosoftDynamicsCRMadoxioEventaddress> GetAsync(this IRegardingobjectidadoxioeventaddress operations, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(asyncoperationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from asyncoperations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioEventaddress> GetWithHttpMessages(this IRegardingobjectidadoxioeventaddress operations, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(asyncoperationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from bulkdeletefailures
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioEventaddress Get1(this IRegardingobjectidadoxioeventaddress operations, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get1Async(bulkdeletefailureid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from bulkdeletefailures
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
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
            public static async Task<MicrosoftDynamicsCRMadoxioEventaddress> Get1Async(this IRegardingobjectidadoxioeventaddress operations, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get1WithHttpMessagesAsync(bulkdeletefailureid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from bulkdeletefailures
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioEventaddress> Get1WithHttpMessages(this IRegardingobjectidadoxioeventaddress operations, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.Get1WithHttpMessagesAsync(bulkdeletefailureid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from mailboxtrackingfolders
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='mailboxtrackingfolderid'>
            /// key: mailboxtrackingfolderid of mailboxtrackingfolder
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioEventaddress Get2(this IRegardingobjectidadoxioeventaddress operations, string mailboxtrackingfolderid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get2Async(mailboxtrackingfolderid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from mailboxtrackingfolders
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='mailboxtrackingfolderid'>
            /// key: mailboxtrackingfolderid of mailboxtrackingfolder
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
            public static async Task<MicrosoftDynamicsCRMadoxioEventaddress> Get2Async(this IRegardingobjectidadoxioeventaddress operations, string mailboxtrackingfolderid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get2WithHttpMessagesAsync(mailboxtrackingfolderid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from mailboxtrackingfolders
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='mailboxtrackingfolderid'>
            /// key: mailboxtrackingfolderid of mailboxtrackingfolder
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioEventaddress> Get2WithHttpMessages(this IRegardingobjectidadoxioeventaddress operations, string mailboxtrackingfolderid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.Get2WithHttpMessagesAsync(mailboxtrackingfolderid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from processsessions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='processsessionid'>
            /// key: processsessionid of processsession
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioEventaddress Get3(this IRegardingobjectidadoxioeventaddress operations, string processsessionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get3Async(processsessionid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from processsessions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='processsessionid'>
            /// key: processsessionid of processsession
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
            public static async Task<MicrosoftDynamicsCRMadoxioEventaddress> Get3Async(this IRegardingobjectidadoxioeventaddress operations, string processsessionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get3WithHttpMessagesAsync(processsessionid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from processsessions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='processsessionid'>
            /// key: processsessionid of processsession
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioEventaddress> Get3WithHttpMessages(this IRegardingobjectidadoxioeventaddress operations, string processsessionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.Get3WithHttpMessagesAsync(processsessionid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from syncerrors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='syncerrorid'>
            /// key: syncerrorid of syncerror
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioEventaddress Get4(this IRegardingobjectidadoxioeventaddress operations, string syncerrorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get4Async(syncerrorid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from syncerrors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='syncerrorid'>
            /// key: syncerrorid of syncerror
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
            public static async Task<MicrosoftDynamicsCRMadoxioEventaddress> Get4Async(this IRegardingobjectidadoxioeventaddress operations, string syncerrorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get4WithHttpMessagesAsync(syncerrorid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get regardingobjectid_adoxio_eventaddress from syncerrors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='syncerrorid'>
            /// key: syncerrorid of syncerror
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioEventaddress> Get4WithHttpMessages(this IRegardingobjectidadoxioeventaddress operations, string syncerrorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.Get4WithHttpMessagesAsync(syncerrorid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
