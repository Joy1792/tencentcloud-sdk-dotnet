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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryOpenBankVerificationOrderResponse : AbstractModel
    {
        
        /// <summary>
        /// 业务系统返回码，SUCCESS表示成功，其他表示失败。
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// 业务系统返回消息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// 核销查询响应对象。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public QueryOpenBankVerificationResult Result{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamObj(map, prefix + "Result.", this.Result);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

