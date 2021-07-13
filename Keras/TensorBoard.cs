using System.Collections.Generic;
using Numpy;

namespace Keras
{
    /// <summary>
    ///     TensorBoard basic visualizations. TensorBoard is a visualization tool provided with TensorFlow.
    ///     This callback writes a log for TensorBoard, which allows you to visualize dynamic graphs of your training and test
    ///     metrics, as well as activation histograms for the different layers in your model.
    ///     If you have installed TensorFlow with pip, you should be able to launch TensorBoard from the command line:
    ///     tensorboard --logdir=/ full_path_to_your_logs
    ///     When using a backend other than TensorFlow, TensorBoard will still work(if you have TensorFlow installed), but the
    ///     only feature available will be the display of the losses and metrics plots.
    /// </summary>
    /// <seealso cref="Keras.Callbacks.Callback" />
    public class TensorBoard : Callback
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LearningRateScheduler" /> class.
        /// </summary>
        /// <param name="log_dir"> the path of the directory where to save the log files to be parsed by TensorBoard.</param>
        /// <param name="histogram_freq">
        ///     frequency (in epochs) at which to compute activation and weight histograms for the layers
        ///     of the model. If set to 0, histograms won't be computed. Validation data (or split) must be specified for histogram
        ///     visualizations.
        /// </param>
        /// <param name="batch_size"> size of batch of inputs to feed to the network for histograms computation.</param>
        /// <param name="write_graph">
        ///     whether to visualize the graph in TensorBoard. The log file can become quite large when
        ///     write_graph is set to True.
        /// </param>
        /// <param name="write_grads">
        ///     whether to visualize gradient histograms in TensorBoard. histogram_freq must be greater than
        ///     0.
        /// </param>
        /// <param name="write_images"> whether to write model weights to visualize as image in TensorBoard.</param>
        /// <param name="embeddings_freq">
        ///     frequency (in epochs) at which selected embedding layers will be saved. If set to 0,
        ///     embeddings won't be computed. Data to be visualized in TensorBoard's Embedding tab must be passed as
        ///     embeddings_data.
        /// </param>
        /// <param name="embeddings_layer_names">
        ///     a list of names of layers to keep eye on. If None or empty list all the embedding
        ///     layer will be watched.
        /// </param>
        /// <param name="embeddings_metadata">
        ///     a dictionary which maps layer name to a file name in which metadata for this
        ///     embedding layer is saved. See the details about metadata files format. In case if the same metadata file is used
        ///     for all embedding layers, string can be passed.
        /// </param>
        /// <param name="embeddings_data">
        ///     data to be embedded at layers specified in embeddings_layer_names. Numpy array (if the
        ///     model has a single input) or list of Numpy arrays (if the model has multiple inputs). Learn more about embeddings.
        /// </param>
        public TensorBoard(string log_dir = "./logs", int histogram_freq = 0, int batch_size = 32,
            bool write_graph = true, bool write_grads = false,
            bool write_images = false, int embeddings_freq = 0, string[] embeddings_layer_names = null,
            Dictionary<string, string> embeddings_metadata = null,
            NDarray embeddings_data = null, string update_freq = "epoch")
        {
            Parameters["log_dir"] = log_dir;
            Parameters["histogram_freq"] = histogram_freq;
            Parameters["batch_size"] = batch_size;
            Parameters["write_graph"] = write_graph;
            Parameters["embeddings_freq"] = embeddings_freq;
            Parameters["embeddings_layer_names"] = embeddings_layer_names;
            Parameters["embeddings_metadata"] = embeddings_metadata;
            Parameters["embeddings_data"] = embeddings_data?.PyObject;
            Parameters["update_freq"] = update_freq;

            PyInstance = Instance.keras.callbacks.TensorBoard;
            Init();
        }
    }
}