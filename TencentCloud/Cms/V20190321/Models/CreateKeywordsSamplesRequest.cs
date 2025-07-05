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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateKeywordsSamplesRequest : AbstractModel
    {
        
        /// <summary>
        /// 关键词库信息：单次限制写入2000个，词库总容量不可超过10000个。
        /// </summary>
        [JsonProperty("UserKeywords")]
        public UserKeyword[] UserKeywords{ get; set; }

        /// <summary>
        /// 词库ID
        /// </summary>
        [JsonProperty("LibID")]
        public string LibID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "UserKeywords.", this.UserKeywords);
            this.SetParamSimple(map, prefix + "LibID", this.LibID);
        }
    }
}

