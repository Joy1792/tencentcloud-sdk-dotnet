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

    public class DescribeSignListStatus : AbstractModel
    {
        
        /// <summary>
        /// 签名ID。
        /// </summary>
        [JsonProperty("SignId")]
        public ulong? SignId{ get; set; }

        /// <summary>
        /// 是否国际/港澳台短信，其中0表示国内短信，1表示国际/港澳台短信。
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// 申请签名状态，其中0表示审核通过且已生效，1表示审核中，2表示审核通过待生效，-1表示审核未通过或审核失败。
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// 审核回复，审核人员审核后给出的回复，通常是审核未通过的原因。
        /// </summary>
        [JsonProperty("ReviewReply")]
        public string ReviewReply{ get; set; }

        /// <summary>
        /// 签名名称。
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// 提交审核时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 国内短信的资质 ID。资质 ID 信息可前往国内短信的 [实名资质管理](https://console.cloud.tencent.com/smsv2/enterprise) 页查看。
        /// 注：国际短信不涉及，默认为0。
        /// </summary>
        [JsonProperty("QualificationId")]
        public ulong? QualificationId{ get; set; }

        /// <summary>
        /// 国内短信的资质名称。
        /// 注：国际短信不涉及，默认为空。
        /// </summary>
        [JsonProperty("QualificationName")]
        public string QualificationName{ get; set; }

        /// <summary>
        /// 国内短信的资质状态。其中0表示待审核，1表示已通过，2表示已拒绝，3表示待补充后提交，4表示变更后待审核，5表示变更后被驳回。可参考 [实名资质审核状态说明](https://cloud.tencent.com/document/product/382/13444#.E5.AE.A1.E6.A0.B8.E7.8A.B6.E6.80.81.E8.AF.B4.E6.98.8E) 。
        /// 注：国际短信不涉及，默认为0。
        /// </summary>
        [JsonProperty("QualificationStatusCode")]
        public long? QualificationStatusCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "ReviewReply", this.ReviewReply);
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "QualificationId", this.QualificationId);
            this.SetParamSimple(map, prefix + "QualificationName", this.QualificationName);
            this.SetParamSimple(map, prefix + "QualificationStatusCode", this.QualificationStatusCode);
        }
    }
}

