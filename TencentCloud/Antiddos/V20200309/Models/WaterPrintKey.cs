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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterPrintKey : AbstractModel
    {
        
        /// <summary>
        /// 密钥版本号
        /// </summary>
        [JsonProperty("KeyVersion")]
        public string KeyVersion{ get; set; }

        /// <summary>
        /// 密钥内容
        /// </summary>
        [JsonProperty("KeyContent")]
        public string KeyContent{ get; set; }

        /// <summary>
        /// 密钥ID
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 密钥启用状态，只有一个取值1(启用)
        /// </summary>
        [JsonProperty("KeyOpenStatus")]
        public long? KeyOpenStatus{ get; set; }

        /// <summary>
        /// 密钥生成时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyVersion", this.KeyVersion);
            this.SetParamSimple(map, prefix + "KeyContent", this.KeyContent);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyOpenStatus", this.KeyOpenStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

