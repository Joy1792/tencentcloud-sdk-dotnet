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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelDescribeBillUsageDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// </ul>
        /// 第三方平台子客企业必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 查询开始时间字符串，格式为yyyymmdd,时间跨度不能大于31天
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间字符串，格式为yyyymmdd,时间跨度不能大于31天
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 查询的套餐类型 （选填 ）不传则查询所有套餐；
        /// 目前支持:
        /// <ul>
        /// <li>**CloudEnterprise**: 企业版合同</li>
        /// <li>**SingleSignature**: 单方签章</li>
        /// <li>**CloudProve**: 签署报告</li>
        /// <li>**CloudOnlineSign**: 腾讯会议在线签约</li>
        /// <li>**ChannelWeCard**: 微工卡</li>
        /// <li>**SignFlow**: 合同套餐</li>
        /// <li>**SignFace**: 签署意愿（人脸识别）</li>
        /// <li>**SignPassword**: 签署意愿（密码）</li>
        /// <li>**SignSMS**: 签署意愿（短信）</li>
        /// <li>**PersonalEssAuth**: 签署人实名（腾讯电子签认证）</li>
        /// <li>**PersonalThirdAuth**: 签署人实名（信任第三方认证）</li>
        /// <li>**OrgEssAuth**: 签署企业实名</li>
        /// <li>**FlowNotify**: 短信通知</li>
        /// <li>**AuthService**: 企业工商信息查询</li>
        /// </ul>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// 指定分页返回第几页的数据，如果不传默认返回第一页，页码从 0 开始，即首页为 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 指定分页每页返回的数据条数，如果不传默认为 50，单页最大支持 50。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

