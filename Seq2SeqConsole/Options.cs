﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seq2SeqSharp;
using AdvUtils;

namespace Seq2SeqConsole
{
    class Options
    {
        [Arg("Task name. It could be train and test", "TaskName")]
        public string TaskName;

        [Arg("The vector size of encoded source word.", "WordVectorSize")]
        public int WordVectorSize = 128;

        [Arg("The hidden layer size of encoder and decoder.", "HiddenSize")]
        public int HiddenSize = 128;

        [Arg("Learning rate.", "LearningRate")]
        public float LearningRate = 0.001f;

        [Arg("The network depth in decoder.", "Depth")]
        public int Depth = 1;

        [Arg("The trained model file path.", "ModelFilePath")]
        public string ModelFilePath = "Seq2Seq.Model";

        [Arg("The vocabulary file path for source side.", "SrcVocab")]
        public string SrcVocab = null;

        [Arg("The vocabulary file path for target side.", "TgtVocab")]
        public string TgtVocab = null;

        [Arg("The external embedding model file path for source side.", "SrcEmbedding")]
        public string SrcEmbeddingModelFilePath = null;

        [Arg("The external embedding model file path for target side.", "TgtEmbedding")]
        public string TgtEmbeddingModelFilePath = null;

        [Arg("Source language name.", "SrcLang")]
        public string SrcLang;

        [Arg("Target language name.", "TgtLang")]
        public string TgtLang;

        [Arg("Training corpus folder path", "TrainCorpusPath")]
        public string TrainCorpusPath;

        [Arg("The input file for test.", "InputTestFile")]
        public string InputTestFile;

        [Arg("The test result file.", "OutputTestFile")]
        public string OutputTestFile;

        [Arg("The shuffle block size", "ShuffleBlockSize")]
        public int ShuffleBlockSize = -1;

        [Arg("Clip gradients", "GradClip")]
        public float GradClip = 5.0f;

        [Arg("The batch size", "BatchSize")]
        public int BatchSize = 1;

        [Arg("Dropout ratio", "Dropout")]
        public float DropoutRatio = 0.1f;

        [Arg("Arch type: 0 - GPU, 1 - CPU, 2 - CPU MKL", "ArchType")]
        public int ArchType = 0;

        [Arg("Device ids for training in GPU mode. Default is 0. For multi devices, ids are split by comma, for example: 0,1,2", "DeviceIds")]
        public string DeviceIds = "0";
    }
}
