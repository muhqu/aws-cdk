using Amazon.CDK;
using Amazon.CDK.AWS.WAFRegional.cloudformation.WebACLResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.WAFRegional.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html </remarks>
    public class WebACLResourceProps : DeputyBase, IWebACLResourceProps
    {
        /// <summary>``AWS::WAFRegional::WebACL.DefaultAction``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html#cfn-wafregional-webacl-defaultaction </remarks>
        [JsiiProperty("defaultAction", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-wafregional.cloudformation.WebACLResource.ActionProperty\"}]}}", true)]
        public object DefaultAction
        {
            get;
            set;
        }

        /// <summary>``AWS::WAFRegional::WebACL.MetricName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html#cfn-wafregional-webacl-metricname </remarks>
        [JsiiProperty("metricName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object MetricName
        {
            get;
            set;
        }

        /// <summary>``AWS::WAFRegional::WebACL.Name``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html#cfn-wafregional-webacl-name </remarks>
        [JsiiProperty("webAclName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object WebAclName
        {
            get;
            set;
        }

        /// <summary>``AWS::WAFRegional::WebACL.Rules``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html#cfn-wafregional-webacl-rules </remarks>
        [JsiiProperty("rules", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-wafregional.cloudformation.WebACLResource.RuleProperty\"}]}}}}]},\"optional\":true}", true)]
        public object Rules
        {
            get;
            set;
        }
    }
}