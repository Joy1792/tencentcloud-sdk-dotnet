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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIp6TranslatorRequest : AbstractModel
    {
        
        /// <summary>
        /// IPV6转换实例唯一ID，形如ip6-xxxxxxxxx
        /// </summary>
        [JsonProperty("Ip6TranslatorId")]
        public string Ip6TranslatorId{ get; set; }

        /// <summary>
        /// IPV6转换实例修改名称
        /// </summary>
        [JsonProperty("Ip6TranslatorName")]
        public string Ip6TranslatorName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip6TranslatorId", this.Ip6TranslatorId);
            this.SetParamSimple(map, prefix + "Ip6TranslatorName", this.Ip6TranslatorName);
        }
    }
}

