using System.Collections.Generic;

namespace Keras
{
    /// <summary>
    ///     Callback used to stream events to a server.
    ///     Requires the requests library.Events are sent to root + '/publish/epoch/end/' by default. Calls are HTTP POST, with
    ///     a data argument which is a JSON-encoded dictionary of event data.If send_as_json is set to True, the content type
    ///     of the request will be application/json.Otherwise the serialized JSON will be send within a form
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class RemoteMonitor : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoteMonitor" /> class.
        /// </summary>
        /// <param name="root">String; root url of the target server.</param>
        /// <param name="path">String; path relative to root to which the events will be sent.</param>
        /// <param name="field">
        ///     String; JSON field under which the data will be stored. The field is used only if the payload is
        ///     sent within a form (i.e. send_as_json is set to False).
        /// </param>
        /// <param name="headers">Dictionary; optional custom HTTP headers.</param>
        /// <param name="send_as_json">Boolean; whether the request should be send as application/json.</param>
        public RemoteMonitor(string root = "http://localhost:9000", string path = "/publish/epoch/end/",
            string field = "data", Dictionary<string, string> headers = null, bool send_as_json = false)
        {
            Parameters["root"] = root;
            Parameters["path"] = path;
            Parameters["field"] = field;
            Parameters["headers"] = headers;
            Parameters["send_as_json"] = send_as_json;

            PyInstance = Instance.keras.callbacks.RemoteMonitor;
            Init();
        }
    }
}