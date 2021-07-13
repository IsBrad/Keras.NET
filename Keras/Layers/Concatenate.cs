using System.Linq;

namespace Keras.Layers
{
    public class Concatenate : Merge
    {
        public Concatenate(int axis = -1, params BaseLayer[] inputs)
        {
            PyInstance = Instance.keras.layers.concatenate(inputs.Select(x => x.ToPython()).ToList(), axis);
        }

        public Concatenate(params BaseLayer[] inputs)
        {
            PyInstance = Instance.keras.layers.concatenate(inputs.Select(x => x.ToPython()).ToList());
        }
    }
}