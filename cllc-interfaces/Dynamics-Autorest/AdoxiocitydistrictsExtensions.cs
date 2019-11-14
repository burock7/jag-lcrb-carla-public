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
    /// Extension methods for Adoxiocitydistricts.
    /// </summary>
    public static partial class AdoxiocitydistrictsExtensions
    {
            /// <summary>
            /// Get entities from adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static MicrosoftDynamicsCRMadoxioCitydistrictCollection Get(this IAdoxiocitydistricts operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static async Task<MicrosoftDynamicsCRMadoxioCitydistrictCollection> GetAsync(this IAdoxiocitydistricts operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCitydistrictCollection> GetWithHttpMessages(this IAdoxiocitydistricts operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(top, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMadoxioCitydistrict Create(this IAdoxiocitydistricts operations, MicrosoftDynamicsCRMadoxioCitydistrict body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioCitydistrict> CreateAsync(this IAdoxiocitydistricts operations, MicrosoftDynamicsCRMadoxioCitydistrict body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCitydistrict> CreateWithHttpMessages(this IAdoxiocitydistricts operations, MicrosoftDynamicsCRMadoxioCitydistrict body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_citydistricts by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioCitydistrict GetByKey(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(adoxioCitydistrictid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_citydistricts by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
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
            public static async Task<MicrosoftDynamicsCRMadoxioCitydistrict> GetByKeyAsync(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(adoxioCitydistrictid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_citydistricts by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCitydistrict> GetByKeyWithHttpMessages(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetByKeyWithHttpMessagesAsync(adoxioCitydistrictid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, MicrosoftDynamicsCRMadoxioCitydistrict body)
            {
                operations.UpdateAsync(adoxioCitydistrictid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, MicrosoftDynamicsCRMadoxioCitydistrict body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(adoxioCitydistrictid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse UpdateWithHttpMessages(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, MicrosoftDynamicsCRMadoxioCitydistrict body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.UpdateWithHttpMessagesAsync(adoxioCitydistrictid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, string ifMatch = default(string))
            {
                operations.DeleteAsync(adoxioCitydistrictid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(adoxioCitydistrictid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_citydistricts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCitydistrictid'>
            /// key: adoxio_citydistrictid of adoxio_citydistrict
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeleteWithHttpMessages(this IAdoxiocitydistricts operations, string adoxioCitydistrictid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(adoxioCitydistrictid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}