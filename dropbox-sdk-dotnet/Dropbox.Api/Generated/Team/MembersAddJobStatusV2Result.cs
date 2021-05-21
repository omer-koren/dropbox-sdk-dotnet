// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The members add job status v2 result object</para>
    /// </summary>
    public class MembersAddJobStatusV2Result
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembersAddJobStatusV2Result> Encoder = new MembersAddJobStatusV2ResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembersAddJobStatusV2Result> Decoder = new MembersAddJobStatusV2ResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersAddJobStatusV2Result" />
        /// class.</para>
        /// </summary>
        public MembersAddJobStatusV2Result()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Complete</para>
        /// </summary>
        public bool IsComplete
        {
            get
            {
                return this is Complete;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Complete, or <c>null</c>.</para>
        /// </summary>
        public Complete AsComplete
        {
            get
            {
                return this as Complete;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Failed</para>
        /// </summary>
        public bool IsFailed
        {
            get
            {
                return this is Failed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Failed, or <c>null</c>.</para>
        /// </summary>
        public Failed AsFailed
        {
            get
            {
                return this as Failed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InProgress</para>
        /// </summary>
        public bool IsInProgress
        {
            get
            {
                return this is InProgress;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InProgress, or <c>null</c>.</para>
        /// </summary>
        public InProgress AsInProgress
        {
            get
            {
                return this as InProgress;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembersAddJobStatusV2Result" />.</para>
        /// </summary>
        private class MembersAddJobStatusV2ResultEncoder : enc.StructEncoder<MembersAddJobStatusV2Result>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembersAddJobStatusV2Result value, enc.IJsonWriter writer)
            {
                if (value is Complete)
                {
                    WriteProperty(".tag", "complete", writer, enc.StringEncoder.Instance);
                    Complete.Encoder.EncodeFields((Complete)value, writer);
                    return;
                }
                if (value is Failed)
                {
                    WriteProperty(".tag", "failed", writer, enc.StringEncoder.Instance);
                    Failed.Encoder.EncodeFields((Failed)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                if (value is InProgress)
                {
                    WriteProperty(".tag", "in_progress", writer, enc.StringEncoder.Instance);
                    InProgress.Encoder.EncodeFields((InProgress)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembersAddJobStatusV2Result" />.</para>
        /// </summary>
        private class MembersAddJobStatusV2ResultDecoder : enc.UnionDecoder<MembersAddJobStatusV2Result>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembersAddJobStatusV2Result"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembersAddJobStatusV2Result Create()
            {
                return new MembersAddJobStatusV2Result();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MembersAddJobStatusV2Result Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "complete":
                        return Complete.Decoder.DecodeFields(reader);
                    case "failed":
                        return Failed.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                    case "in_progress":
                        return InProgress.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The asynchronous job has finished. For each member that was specified in the
        /// parameter <see cref="MembersAddArg" /> that was provided to <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.MembersAddV2Async" />, a corresponding
        /// item is returned in this list.</para>
        /// </summary>
        public sealed class Complete : MembersAddJobStatusV2Result
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Complete> Encoder = new CompleteEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Complete> Decoder = new CompleteDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Complete" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Complete(col.IEnumerable<MemberAddV2Result> value)
            {
                this.Value = new col.List<MemberAddV2Result>(value);
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Complete" /> class.</para>
            /// </summary>
            private Complete()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public col.IList<MemberAddV2Result> Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteEncoder : enc.StructEncoder<Complete>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Complete value, enc.IJsonWriter writer)
                {
                    WriteListProperty("complete", value.Value, writer, global::Dropbox.Api.Team.MemberAddV2Result.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteDecoder : enc.StructDecoder<Complete>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Complete" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Complete Create()
                {
                    return new Complete();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Complete value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "complete":
                            value.Value = ReadList<MemberAddV2Result>(reader, global::Dropbox.Api.Team.MemberAddV2Result.Decoder);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The asynchronous job returned an error. The string contains an error
        /// message.</para>
        /// </summary>
        public sealed class Failed : MembersAddJobStatusV2Result
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Failed> Encoder = new FailedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Failed> Decoder = new FailedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failed" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Failed(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failed" /> class.</para>
            /// </summary>
            private Failed()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Failed" />.</para>
            /// </summary>
            private class FailedEncoder : enc.StructEncoder<Failed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Failed value, enc.IJsonWriter writer)
                {
                    WriteProperty("failed", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Failed" />.</para>
            /// </summary>
            private class FailedDecoder : enc.StructDecoder<Failed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Failed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Failed Create()
                {
                    return new Failed();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Failed value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "failed":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : MembersAddJobStatusV2Result
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The asynchronous job is still in progress.</para>
        /// </summary>
        public sealed class InProgress : MembersAddJobStatusV2Result
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InProgress> Encoder = new InProgressEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InProgress> Decoder = new InProgressDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InProgress" /> class.</para>
            /// </summary>
            private InProgress()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InProgress</para>
            /// </summary>
            public static readonly InProgress Instance = new InProgress();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InProgress" />.</para>
            /// </summary>
            private class InProgressEncoder : enc.StructEncoder<InProgress>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InProgress value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InProgress" />.</para>
            /// </summary>
            private class InProgressDecoder : enc.StructDecoder<InProgress>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InProgress" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InProgress Create()
                {
                    return InProgress.Instance;
                }

            }

            #endregion
        }
    }
}