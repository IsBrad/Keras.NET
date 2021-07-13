﻿namespace Keras
{
    /// <summary>
    ///     Regularizers allow to apply penalties on layer parameters or layer activity during optimization. These penalties
    ///     are incorporated in the loss function that the network optimizes.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class L1L2 : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="L1L2" /> class.
        /// </summary>
        /// <param name="l1">The l1.</param>
        /// <param name="l2">The l2.</param>
        public L1L2(float l1 = 0.01f, float l2 = 0.01f)
        {
            Parameters["l1"] = l1;
            Parameters["l2"] = l2;
            PyInstance = Instance.keras.regularizers.L1L2;
            Init();
        }
    }
}