using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Convolutional LSTM. It is similar to an LSTM layer, but the input transformations and recurrent transformations are
    ///     both convolutional.
    /// </summary>
    /// <seealso cref="Keras.Layers.RNN" />
    public class ConvLSTM2D : RNN
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ConvLSTM2D" /> class.
        /// </summary>
        /// <param name="filters">
        ///     Integer, the dimensionality of the output space (i.e. the number output of filters in the
        ///     convolution).
        /// </param>
        /// <param name="kernel_size">An integer or tuple/list of n integers, specifying the dimensions of the convolution window.</param>
        /// <param name="strides">
        ///     An integer or tuple/list of n integers, specifying the strides of the convolution. Specifying any
        ///     stride value != 1 is incompatible with specifying any dilation_rate value != 1.
        /// </param>
        /// <param name="padding">One of "valid" or "same" (case-insensitive).</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" (default) or "channels_first". The ordering of the
        ///     dimensions in the inputs. "channels_last" corresponds to inputs with shape (batch, time, ..., channels) while
        ///     "channels_first" corresponds to inputs with shape (batch, time, channels, ...). It defaults to the
        ///     image_data_format value found in your Keras config file at ~/.keras/keras.json. If you never set it, then it will
        ///     be "channels_last".
        /// </param>
        /// <param name="dilation_rate">
        ///     An integer or tuple/list of n integers, specifying the dilation rate to use for dilated
        ///     convolution. Currently, specifying any dilation_rate value != 1 is incompatible with specifying any strides value
        ///     != 1.
        /// </param>
        /// <param name="activation">
        ///     Activation function to use (see activations). If you don't specify anything, no activation is
        ///     applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="recurrent_activation">Activation function to use for the recurrent step (see activations).</param>
        /// <param name="use_bias">Boolean, whether the layer uses a bias vector.</param>
        /// <param name="kernel_initializer">
        ///     Initializer for the kernel weights matrix, used for the linear transformation of the
        ///     inputs. (see initializers).
        /// </param>
        /// <param name="recurrent_initializer">
        ///     Initializer for the recurrent_kernel weights matrix, used for the linear
        ///     transformation of the recurrent state. (see initializers).
        /// </param>
        /// <param name="bias_initializer">Initializer for the bias vector (see initializers).</param>
        /// <param name="unit_forget_bias">
        ///     Boolean. If True, add 1 to the bias of the forget gate at initialization. Use in
        ///     combination with bias_initializer="zeros". This is recommended in Jozefowicz et al. (2015).
        /// </param>
        /// <param name="kernel_regularizer">Regularizer function applied to the kernel weights matrix (see regularizer).</param>
        /// <param name="recurrent_regularizer">
        ///     Regularizer function applied to the recurrent_kernel weights matrix (see
        ///     regularizer).
        /// </param>
        /// <param name="bias_regularizer">Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its "activation"). (see
        ///     regularizer).
        /// </param>
        /// <param name="kernel_constraint">Constraint function applied to the kernel weights matrix (see constraints).</param>
        /// <param name="recurrent_constraint">
        ///     Constraint function applied to the recurrent_kernel weights matrix (see
        ///     constraints).
        /// </param>
        /// <param name="bias_constraint">Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="return_sequences">Boolean. Whether to return the last output in the output sequence, or the full sequence.</param>
        /// <param name="go_backwards">Boolean (default False). If True, process the input sequence backwards.</param>
        /// <param name="stateful">
        ///     Boolean (default False). If True, the last state for each sample at index i in a batch will be
        ///     used as initial state for the sample of index i in the following batch.
        /// </param>
        /// <param name="dropout">Float between 0 and 1. Fraction of the units to drop for the linear transformation of the inputs.</param>
        /// <param name="recurrent_dropout">
        ///     Float between 0 and 1. Fraction of the units to drop for the linear transformation of
        ///     the recurrent state.
        /// </param>
        /// <param name="input_shape">The input shape.</param>
        public ConvLSTM2D(int filters, Tuple<int, int> kernel_size, Tuple<int, int> strides = null,
            string padding = "valid", string data_format = "",
            Tuple<int, int> dilation_rate = null, string activation = "tanh",
            string recurrent_activation = "hard_sigmoid", bool use_bias = true,
            string kernel_initializer = "glorot_uniform", string recurrent_initializer = "orthogonal",
            string bias_initializer = "zeros",
            bool unit_forget_bias = true, string kernel_regularizer = "", string recurrent_regularizer = "",
            string bias_regularizer = "",
            string activity_regularizer = "", string kernel_constraint = "", string recurrent_constraint = "",
            string bias_constraint = "",
            bool return_sequences = false, bool go_backwards = false, bool stateful = false, float dropout = 0.0f,
            float recurrent_dropout = 0.0f, Shape input_shape = null)
        {
            Parameters["filters"] = filters;
            Parameters["kernel_size"] = new Shape(kernel_size.Item1, kernel_size.Item2);
            Parameters["strides"] = strides;
            Parameters["padding"] = padding;
            Parameters["data_format"] = data_format;
            Parameters["dilation_rate"] = dilation_rate != null
                ? new Shape(dilation_rate.Item1, dilation_rate.Item2)
                : new Shape(1, 1);
            Parameters["activation"] = activation;
            Parameters["recurrent_activation"] = recurrent_activation;
            Parameters["use_bias"] = use_bias;
            Parameters["kernel_initializer"] = kernel_initializer;
            Parameters["recurrent_initializer"] = recurrent_initializer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["unit_forget_bias"] = unit_forget_bias;
            Parameters["kernel_regularizer"] = kernel_regularizer;
            Parameters["recurrent_regularizer"] = recurrent_regularizer;
            Parameters["bias_regularizer"] = bias_regularizer;
            Parameters["activity_regularizer"] = activity_regularizer;
            Parameters["kernel_constraint"] = kernel_constraint;
            Parameters["recurrent_constraint"] = recurrent_constraint;
            Parameters["bias_constraint"] = bias_constraint;
            Parameters["return_sequences"] = return_sequences;
            Parameters["go_backwards"] = go_backwards;
            Parameters["stateful"] = stateful;
            Parameters["dropout"] = dropout;
            Parameters["recurrent_dropout"] = recurrent_dropout;
            Parameters["input_shape"] = input_shape;

            PyInstance = Instance.keras.layers.ConvLSTM2D;
            Init();
        }
    }
}