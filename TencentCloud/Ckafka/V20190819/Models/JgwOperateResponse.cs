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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JgwOperateResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回的code，0为正常，非0为错误
        /// </summary>
        [JsonProperty("ReturnCode")]
        public string ReturnCode{ get; set; }

        /// <summary>
        /// 成功消息
        /// </summary>
        [JsonProperty("ReturnMessage")]
        public string ReturnMessage{ get; set; }

        /// <summary>
        /// 操作型返回的Data数据,可能有flowId等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Data")]
        public OperateResponseData Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMessage", this.ReturnMessage);
            this.SetParamObj(map, prefix + "Data.", this.Data);
        }
    }
}

