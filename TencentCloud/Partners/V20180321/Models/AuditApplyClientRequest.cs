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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditApplyClientRequest : AbstractModel
    {
        
        /// <summary>
        /// 待审核客户账号ID
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 审核结果，可能的取值：accept/reject
        /// </summary>
        [JsonProperty("AuditResult")]
        public string AuditResult{ get; set; }

        /// <summary>
        /// 申请理由，B类客户审核通过时必须填写申请理由
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "AuditResult", this.AuditResult);
            this.SetParamSimple(map, prefix + "Note", this.Note);
        }
    }
}

