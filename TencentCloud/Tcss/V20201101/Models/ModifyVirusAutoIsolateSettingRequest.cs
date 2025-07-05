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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVirusAutoIsolateSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 自动隔离开关(true:开 false:关)
        /// </summary>
        [JsonProperty("AutoIsolateSwitch")]
        public bool? AutoIsolateSwitch{ get; set; }

        /// <summary>
        /// 是否中断隔离文件关联的进程(true:是 false:否)
        /// </summary>
        [JsonProperty("IsKillProgress")]
        public bool? IsKillProgress{ get; set; }

        /// <summary>
        /// 用户用户自定义开关
        /// </summary>
        [JsonProperty("UserAutoIsolateKillSwitch")]
        public bool? UserAutoIsolateKillSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoIsolateSwitch", this.AutoIsolateSwitch);
            this.SetParamSimple(map, prefix + "IsKillProgress", this.IsKillProgress);
            this.SetParamSimple(map, prefix + "UserAutoIsolateKillSwitch", this.UserAutoIsolateKillSwitch);
        }
    }
}

