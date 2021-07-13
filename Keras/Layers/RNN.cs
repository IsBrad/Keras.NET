namespace Keras.Layers
{
    /// <summary>
    ///     Base class for recurrent layers.
    ///     This layer supports masking for input data with a variable number of timesteps. To introduce masks to your data,
    ///     use an Embedding layer with the mask_zero parameter set to True.
    ///     <para>
    ///         You can set RNN layers to be 'stateful', which means that the states computed for the samples in one batch will
    ///         be reused as initial states for the samples in the next batch. This assumes a one-to-one mapping between
    ///         samples in different successive batches.
    ///         To enable statefulness: - specify stateful = True in the layer constructor. - specify a fixed batch size for
    ///         your model, by passing if sequential model: batch_input_shape = (...) to the first layer in your model. else
    ///         for functional model with 1 or more Input layers: batch_shape = (...) to all the first layers in your
    ///         model.This is the expected shape of your inputs including the batch size.It should be a tuple of integers, e.g.
    ///         (32, 10, 100). - specify shuffle = False when calling fit().
    ///         To reset the states of your model, call.reset_states() on either a specific layer, or on your entire model.
    ///     </para>
    ///     <para>
    ///         You can specify the initial state of RNN layers symbolically by calling them with the keyword argument
    ///         initial_state.
    ///         The value of initial_state should be a tensor or list of tensors representing the initial state of the RNN
    ///         layer.
    ///         You can specify the initial state of RNN layers numerically by calling reset_states with the keyword argument
    ///         states.The value of states should be a numpy array or list of numpy arrays representing the initial state of
    ///         the RNN layer.
    ///     </para>
    ///     <para>
    ///         You can pass "external" constants to the cell using the constants keyword argument of RNN.__call__ (as well as
    ///         RNN.call) method. This requires that the cell.
    ///         Call method accepts the same keyword argument constants. Such constants can be used to condition the cell
    ///         transformation on additional static inputs (not changing over time), a.k.a. an attention mechanism.
    ///     </para>
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class RNN : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RNN" /> class.
        /// </summary>
        public RNN()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RNN" /> class.
        /// </summary>
        /// <param name="cell">A RNN cell instance.</param>
        /// <param name="return_sequences">Boolean. Whether to return the last output in the output sequence, or the full sequence.</param>
        /// <param name="return_state">Boolean. Whether to return the last state in addition to the output.</param>
        /// <param name="go_backwards">
        ///     Boolean (default False). If True, process the input sequence backwards and return the
        ///     reversed sequence.
        /// </param>
        /// <param name="stateful">
        ///     Boolean (default False). If True, the last state for each sample at index i in a batch will be
        ///     used as initial state for the sample of index i in the following batch.
        /// </param>
        /// <param name="unroll">
        ///     Boolean (default False). If True, the network will be unrolled, else a symbolic loop will be used.
        ///     Unrolling can speed-up a RNN, although it tends to be more memory-intensive. Unrolling is only suitable for short
        ///     sequences.
        /// </param>
        /// <param name="input_dim">
        ///     dimensionality of the input (integer). This argument (or alternatively, the keyword argument
        ///     input_shape) is required when using this layer as the first layer in a model..
        /// </param>
        /// <param name="input_length">
        ///     Length of input sequences, to be specified when it is constant. This argument is required if
        ///     you are going to connect  Flatten then Dense layers upstream (without it, the shape of the dense outputs cannot be
        ///     computed). Note that if the recurrent layer is not the first layer in your model, you would need to specify the
        ///     input length at the level of the first layer (e.g. via the input_shape argument)
        /// </param>
        /// <param name="input_shape">3D tensor with shape (batch_size, timesteps, input_dim).</param>
        public RNN(RNN cell, bool return_sequences = false, bool return_state = false, bool go_backwards = false,
            bool stateful = false, bool unroll = false, int? input_dim = null, int? input_length = null,
            Shape input_shape = null)
        {
            Parameters["cell"] = cell.PyInstance;
            Parameters["return_sequences"] = return_sequences;
            Parameters["return_state"] = return_state;
            Parameters["go_backwards"] = go_backwards;
            Parameters["stateful"] = stateful;
            Parameters["unroll"] = unroll;
            PyInstance = Instance.keras.layers.RNN;
            Init();
        }
    }
}