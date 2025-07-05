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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChargeDetail : AbstractModel
    {
        
        /// <summary>
        /// 一比一时间时间戳，13位。
        /// </summary>
        [JsonProperty("ReqTime")]
        public string ReqTime{ get; set; }

        /// <summary>
        /// 一比一请求的唯一标记。
        /// </summary>
        [JsonProperty("Seq")]
        public string Seq{ get; set; }

        /// <summary>
        /// 一比一时使用的、脱敏后的身份证号。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 已废弃。请使用“IdCard”字段
        /// </summary>
        [JsonProperty("Idcard")]
        [System.Obsolete]
        public string Idcard{ get; set; }

        /// <summary>
        /// 一比一时使用的、脱敏后的姓名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 一比一的相似度。0-100，保留2位小数。
        /// </summary>
        [JsonProperty("Sim")]
        public string Sim{ get; set; }

        /// <summary>
        /// 本次详情是否收费。
        /// </summary>
        [JsonProperty("IsNeedCharge")]
        public bool? IsNeedCharge{ get; set; }

        /// <summary>
        /// 收费类型，比对、核身、混合部署。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 本次活体一比一最终结果。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// 本次活体一比一最终结果描述。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReqTime", this.ReqTime);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Idcard", this.Idcard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sim", this.Sim);
            this.SetParamSimple(map, prefix + "IsNeedCharge", this.IsNeedCharge);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
        }
    }
}

