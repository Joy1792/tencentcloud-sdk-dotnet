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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnhancedService : AbstractModel
    {
        
        /// <summary>
        /// 是否开启云镜服务。
        /// </summary>
        [JsonProperty("SecurityService")]
        public RunSecurityServiceEnabled SecurityService{ get; set; }

        /// <summary>
        /// 是否开启云监控服务。
        /// </summary>
        [JsonProperty("MonitorService")]
        public RunMonitorServiceEnabled MonitorService{ get; set; }

        /// <summary>
        /// 是否开通IP直通。若不指定该参数，则Linux镜像默认开通，windows镜像暂不支持IP直通。
        /// </summary>
        [JsonProperty("EIPDirectService")]
        public RunEIPDirectServiceEnabled EIPDirectService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SecurityService.", this.SecurityService);
            this.SetParamObj(map, prefix + "MonitorService.", this.MonitorService);
            this.SetParamObj(map, prefix + "EIPDirectService.", this.EIPDirectService);
        }
    }
}

