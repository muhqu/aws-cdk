using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html </remarks>
    [JsiiInterfaceProxy(typeof(IRedirectRuleProperty), "@aws-cdk/aws-s3.cloudformation.BucketResource.RedirectRuleProperty")]
    internal class RedirectRulePropertyProxy : DeputyBase, IRedirectRuleProperty
    {
        private RedirectRulePropertyProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>``BucketResource.RedirectRuleProperty.HostName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-hostname </remarks>
        [JsiiProperty("hostName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        public virtual object HostName
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``BucketResource.RedirectRuleProperty.HttpRedirectCode``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-httpredirectcode </remarks>
        [JsiiProperty("httpRedirectCode", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        public virtual object HttpRedirectCode
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``BucketResource.RedirectRuleProperty.Protocol``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-protocol </remarks>
        [JsiiProperty("protocol", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        public virtual object Protocol
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``BucketResource.RedirectRuleProperty.ReplaceKeyPrefixWith``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-replacekeyprefixwith </remarks>
        [JsiiProperty("replaceKeyPrefixWith", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        public virtual object ReplaceKeyPrefixWith
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``BucketResource.RedirectRuleProperty.ReplaceKeyWith``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-replacekeywith </remarks>
        [JsiiProperty("replaceKeyWith", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        public virtual object ReplaceKeyWith
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }
    }
}