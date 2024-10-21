/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PullSmsSendStatus : AbstractModel
    {
        
        /// <summary>
        /// 用户实际接收到短信的时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("UserReceiveTime")]
        public ulong? UserReceiveTime{ get; set; }

        /// <summary>
        /// 国家（或地区）码。
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// 用户号码，普通格式，示例如：18501234444。
        /// </summary>
        [JsonProperty("SubscriberNumber")]
        public string SubscriberNumber{ get; set; }

        /// <summary>
        /// 手机号码，E.164标准，+[国家或地区码][手机号] ，示例如：+8618501234444， 其中前面有一个+号 ，86为国家码，18501234444为手机号。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 本次发送标识 ID。
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// 实际是否收到短信接收状态，SUCCESS（成功）、FAIL（失败）。
        /// </summary>
        [JsonProperty("ReportStatus")]
        public string ReportStatus{ get; set; }

        /// <summary>
        /// 用户接收短信状态描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 用户的 session 内容。与请求中的 SessionContext 一致，默认为空，如需开通请联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) 评估。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserReceiveTime", this.UserReceiveTime);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "SubscriberNumber", this.SubscriberNumber);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "ReportStatus", this.ReportStatus);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
        }
    }
}

