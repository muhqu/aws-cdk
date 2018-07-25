using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Amazon.CDK.AWS.Glue.cloudformation.PartitionResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html </remarks>
    [JsiiInterfaceProxy(typeof(ISkewedInfoProperty), "@aws-cdk/aws-glue.cloudformation.PartitionResource.SkewedInfoProperty")]
    internal class SkewedInfoPropertyProxy : DeputyBase, Amazon.CDK.AWS.Glue.cloudformation.PartitionResource.ISkewedInfoProperty
    {
        private SkewedInfoPropertyProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>``PartitionResource.SkewedInfoProperty.SkewedColumnNames``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnnames </remarks>
        [JsiiProperty("skewedColumnNames", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}")]
        public virtual object SkewedColumnNames
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``PartitionResource.SkewedInfoProperty.SkewedColumnValueLocationMaps``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnvaluelocationmaps </remarks>
        [JsiiProperty("skewedColumnValueLocationMaps", "{\"union\":{\"types\":[{\"primitive\":\"json\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        public virtual object SkewedColumnValueLocationMaps
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``PartitionResource.SkewedInfoProperty.SkewedColumnValues``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnvalues </remarks>
        [JsiiProperty("skewedColumnValues", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}")]
        public virtual object SkewedColumnValues
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }
    }
}