using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Cognito.cloudformation.IdentityPoolResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html </remarks>
    [JsiiInterface(typeof(ICognitoIdentityProviderProperty), "@aws-cdk/aws-cognito.cloudformation.IdentityPoolResource.CognitoIdentityProviderProperty")]
    public interface ICognitoIdentityProviderProperty
    {
        /// <summary>``IdentityPoolResource.CognitoIdentityProviderProperty.ClientId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html#cfn-cognito-identitypool-cognitoidentityprovider-clientid </remarks>
        [JsiiProperty("clientId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object ClientId
        {
            get;
            set;
        }

        /// <summary>``IdentityPoolResource.CognitoIdentityProviderProperty.ProviderName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html#cfn-cognito-identitypool-cognitoidentityprovider-providername </remarks>
        [JsiiProperty("providerName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object ProviderName
        {
            get;
            set;
        }

        /// <summary>``IdentityPoolResource.CognitoIdentityProviderProperty.ServerSideTokenCheck``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html#cfn-cognito-identitypool-cognitoidentityprovider-serversidetokencheck </remarks>
        [JsiiProperty("serverSideTokenCheck", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object ServerSideTokenCheck
        {
            get;
            set;
        }
    }
}