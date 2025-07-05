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

    public class SwitchWaterPrintConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 水印开启/关闭状态，1表示开启；0表示关闭
        /// </summary>
        [JsonProperty("OpenStatus")]
        public long? OpenStatus{ get; set; }

        /// <summary>
        /// 是否开启代理，1开启则忽略IP+端口校验；0关闭则需要IP+端口校验
        /// </summary>
        [JsonProperty("CloudSdkProxy")]
        public long? CloudSdkProxy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OpenStatus", this.OpenStatus);
            this.SetParamSimple(map, prefix + "CloudSdkProxy", this.CloudSdkProxy);
        }
    }
}

