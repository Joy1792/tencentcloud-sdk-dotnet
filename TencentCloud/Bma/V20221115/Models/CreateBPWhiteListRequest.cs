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

namespace TencentCloud.Bma.V20221115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBPWhiteListRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业Id
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 白名单类型：0-网站 1-应用 2-公众号 3-小程
        /// </summary>
        [JsonProperty("WhiteListType")]
        public long? WhiteListType{ get; set; }

        /// <summary>
        /// 白名单名称
        /// </summary>
        [JsonProperty("WhiteLists")]
        public string[] WhiteLists{ get; set; }

        /// <summary>
        /// 白名单备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "WhiteListType", this.WhiteListType);
            this.SetParamArraySimple(map, prefix + "WhiteLists.", this.WhiteLists);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

