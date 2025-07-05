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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartStopServiceOrMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 操作类型，当前支持
        /// <li>StartService：启动服务</li>
        /// <li>StopService：停止服务</li>
        /// <li>StartMonitor：退出维护</li>
        /// <li>StopMonitor：进入维护</li>
        /// <li>RestartService：重启服务 如果操作类型选择重启服务 StrategyConfig操作策略则是必填项</li>
        /// </summary>
        [JsonProperty("OpType")]
        public string OpType{ get; set; }

        /// <summary>
        /// 操作范围
        /// </summary>
        [JsonProperty("OpScope")]
        public OpScope OpScope{ get; set; }

        /// <summary>
        /// 操作策略
        /// </summary>
        [JsonProperty("StrategyConfig")]
        public StrategyConfig StrategyConfig{ get; set; }

        /// <summary>
        /// 暂停服务时用的参数
        /// </summary>
        [JsonProperty("StopParams")]
        public StopParams StopParams{ get; set; }

        /// <summary>
        /// 当OpType为<li>StopMonitor</li>才有用，true表示进入维护模式但是仍然监控进程但是不拉起进程
        /// </summary>
        [JsonProperty("KeepMonitorButNotRecoverProcess")]
        public bool? KeepMonitorButNotRecoverProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OpType", this.OpType);
            this.SetParamObj(map, prefix + "OpScope.", this.OpScope);
            this.SetParamObj(map, prefix + "StrategyConfig.", this.StrategyConfig);
            this.SetParamObj(map, prefix + "StopParams.", this.StopParams);
            this.SetParamSimple(map, prefix + "KeepMonitorButNotRecoverProcess", this.KeepMonitorButNotRecoverProcess);
        }
    }
}

