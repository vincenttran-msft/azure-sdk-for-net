// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Defines a Sampling Algorithm that generates values randomly
    /// Serialized Name: RandomSamplingAlgorithm
    /// </summary>
    public partial class RandomSamplingAlgorithm : SamplingAlgorithm
    {
        /// <summary> Initializes a new instance of RandomSamplingAlgorithm. </summary>
        public RandomSamplingAlgorithm()
        {
            SamplingAlgorithmType = SamplingAlgorithmType.Random;
        }

        /// <summary> Initializes a new instance of RandomSamplingAlgorithm. </summary>
        /// <param name="samplingAlgorithmType">
        /// [Required] The algorithm used for generating hyperparameter values, along with configuration properties
        /// Serialized Name: SamplingAlgorithm.samplingAlgorithmType
        /// </param>
        /// <param name="rule">
        /// The specific type of random algorithm
        /// Serialized Name: RandomSamplingAlgorithm.rule
        /// </param>
        /// <param name="seed">
        /// An optional integer to use as the seed for random number generation
        /// Serialized Name: RandomSamplingAlgorithm.seed
        /// </param>
        internal RandomSamplingAlgorithm(SamplingAlgorithmType samplingAlgorithmType, RandomSamplingAlgorithmRule? rule, int? seed) : base(samplingAlgorithmType)
        {
            Rule = rule;
            Seed = seed;
            SamplingAlgorithmType = samplingAlgorithmType;
        }

        /// <summary>
        /// The specific type of random algorithm
        /// Serialized Name: RandomSamplingAlgorithm.rule
        /// </summary>
        public RandomSamplingAlgorithmRule? Rule { get; set; }
        /// <summary>
        /// An optional integer to use as the seed for random number generation
        /// Serialized Name: RandomSamplingAlgorithm.seed
        /// </summary>
        public int? Seed { get; set; }
    }
}
