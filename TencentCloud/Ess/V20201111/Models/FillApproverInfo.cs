/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FillApproverInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署方经办人在模板中配置的参与方ID，与控件绑定，是控件的归属方，ID为32位字符串。
        /// 模板发起合同时，该参数为必填项。
        /// 文件发起合同时，该参数无需传值。
        /// 如果开发者后序用合同模板发起合同，建议保存此值，在用合同模板发起合同中需此值绑定对应的签署经办人 。
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 签署人来源
        /// WEWORKAPP: 企业微信
        /// <br/>仅【企微或签】时指定WEWORKAPP
        /// </summary>
        [JsonProperty("ApproverSource")]
        public string ApproverSource{ get; set; }

        /// <summary>
        /// 企业微信UserId
        /// <br/>当ApproverSource为WEWORKAPP的企微或签场景下，必须指企业自有应用获取企业微信的UserId
        /// </summary>
        [JsonProperty("CustomUserId")]
        public string CustomUserId{ get; set; }

        /// <summary>
        /// 补充企业签署人员工姓名
        /// <ul>
        /// <li>ApproverSource!=WEWORKAPP时，必传</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// 补充企业签署人员工手机号
        /// <ul>
        /// <li>ApproverSource!=WEWORKAPP时，必传</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ApproverMobile")]
        public string ApproverMobile{ get; set; }

        /// <summary>
        /// 补充企业动态签署人时，需要指定对应企业名称
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 签署方经办人的证件类型，支持以下类型
        /// <ul><li>ID_CARD 中国大陆居民身份证</li>
        /// <li>HONGKONG_AND_MACAO 中国港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN 中国港澳台居民居住证(格式同中国大陆居民身份证)</li>
        /// <li>OTHER_CARD_TYPE 其他证件</li></ul>
        /// 
        /// 注: `1.其他证件类型为白名单功能，使用前请联系对接的客户经理沟通。`
        /// `2.补充个人签署方时，若该用户已在电子签完成实名则可通过指定姓名和证件类型、证件号码完成补充。`
        /// </summary>
        [JsonProperty("ApproverIdCardType")]
        public string ApproverIdCardType{ get; set; }

        /// <summary>
        /// 签署方经办人的证件号码，应符合以下规则
        /// <ul><li>中国大陆居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li>
        /// <li>中国港澳居民来往内地通行证号码共11位。第1位为字母，“H”字头签发给中国香港居民，“M”字头签发给中国澳门居民；第2位至第11位为数字</li>
        /// <li>中国港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串</li></ul>
        /// 
        /// 注：`补充个人签署方时，若该用户已在电子签完成实名则可通过指定姓名和证件类型、证件号码完成补充。`
        /// </summary>
        [JsonProperty("ApproverIdCardNumber")]
        public string ApproverIdCardNumber{ get; set; }

        /// <summary>
        /// 合同流程ID
        /// - 补充合同组子合同动态签署人时必传。
        /// - 补充普通合同时，请阅读：<a href="https://qian.tencent.com/developers/companyApis/operateFlows/CreateFlowApprovers/" target="_blank">补充签署人接口</a>的接口使用说明
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 通知类型：
        /// <li>当FillApproverType =0，或签场景补充签署人时，指定是否发送或签领取短信</li>
        /// 
        /// <li>SMS：开启或签领取短信通知</li>
        /// 
        /// <li>NONE：关闭或签领取短信通知</li>
        /// 
        /// <li>当NotifyType=NONE时，可调用<a href="https://qian.tencent.com/developers/companyApis/startFlows/CreateSchemeUrl" target="_blank" rel="noopener noreferrer">获取跳转至腾讯电子签小程序的签署链接</a>接口生成签署链接来完成或签领取</li>
        /// 
        /// 
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "ApproverSource", this.ApproverSource);
            this.SetParamSimple(map, prefix + "CustomUserId", this.CustomUserId);
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproverMobile", this.ApproverMobile);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "ApproverIdCardType", this.ApproverIdCardType);
            this.SetParamSimple(map, prefix + "ApproverIdCardNumber", this.ApproverIdCardNumber);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
        }
    }
}

