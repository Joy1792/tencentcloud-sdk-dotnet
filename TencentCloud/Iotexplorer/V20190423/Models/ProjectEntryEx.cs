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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProjectEntryEx : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        [JsonProperty("ProjectDesc")]
        public string ProjectDesc{ get; set; }

        /// <summary>
        /// 项目创建时间，unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 项目更新时间，unix时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        [JsonProperty("ProductCount")]
        public ulong? ProductCount{ get; set; }

        /// <summary>
        /// NativeApp数量
        /// </summary>
        [JsonProperty("NativeAppCount")]
        public ulong? NativeAppCount{ get; set; }

        /// <summary>
        /// WebApp数量
        /// </summary>
        [JsonProperty("WebAppCount")]
        public ulong? WebAppCount{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 应用数量
        /// </summary>
        [JsonProperty("ApplicationCount")]
        public ulong? ApplicationCount{ get; set; }

        /// <summary>
        /// 设备注册总数
        /// </summary>
        [JsonProperty("DeviceCount")]
        public ulong? DeviceCount{ get; set; }

        /// <summary>
        /// 是否开通物联使能
        /// </summary>
        [JsonProperty("EnableOpenState")]
        public ulong? EnableOpenState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ProjectDesc", this.ProjectDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ProductCount", this.ProductCount);
            this.SetParamSimple(map, prefix + "NativeAppCount", this.NativeAppCount);
            this.SetParamSimple(map, prefix + "WebAppCount", this.WebAppCount);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ApplicationCount", this.ApplicationCount);
            this.SetParamSimple(map, prefix + "DeviceCount", this.DeviceCount);
            this.SetParamSimple(map, prefix + "EnableOpenState", this.EnableOpenState);
        }
    }
}

