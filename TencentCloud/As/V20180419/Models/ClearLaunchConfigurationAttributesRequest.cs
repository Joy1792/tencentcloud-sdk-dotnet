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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClearLaunchConfigurationAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 启动配置ID。可通过如下方式获取：
        /// <li>通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/config) 查询启动配置ID。</li>
        /// <li>通过调用接口 [DescribeLaunchConfigurations](https://cloud.tencent.com/document/api/377/20445) ，取返回信息中的 LaunchConfigurationId 获取启动配置ID。</li>
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 是否清空数据盘信息，非必填，默认为 false。
        /// 填 true 代表清空“数据盘”信息，清空后基于此新创建的云主机将不含有任何数据盘。
        /// </summary>
        [JsonProperty("ClearDataDisks")]
        public bool? ClearDataDisks{ get; set; }

        /// <summary>
        /// 是否清空云服务器主机名相关设置信息，非必填，默认为 false。
        /// 填 true 代表清空主机名设置信息，清空后基于此新创建的云主机将不设置主机名。
        /// </summary>
        [JsonProperty("ClearHostNameSettings")]
        public bool? ClearHostNameSettings{ get; set; }

        /// <summary>
        /// 是否清空云服务器实例名相关设置信息，非必填，默认为 false。
        /// 填 true 代表清空主机名设置信息，清空后基于此新创建的云主机将按照“as-{{ 伸缩组AutoScalingGroupName }}”进行设置。
        /// </summary>
        [JsonProperty("ClearInstanceNameSettings")]
        public bool? ClearInstanceNameSettings{ get; set; }

        /// <summary>
        /// 是否清空置放群组信息，非必填，默认为 false。
        /// 填 true 代表清空置放群组信息，清空后基于此新创建的云主机将不指定任何置放群组。
        /// </summary>
        [JsonProperty("ClearDisasterRecoverGroupIds")]
        public bool? ClearDisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 是否清空实例标签列表，非必填，默认为 false。
        /// 填 true 代表清空实例标签列表，清空后基于此新创建的云主机将不会绑定列表中的标签。
        /// </summary>
        [JsonProperty("ClearInstanceTags")]
        public bool? ClearInstanceTags{ get; set; }

        /// <summary>
        /// 是否清空 MetaData，非必填，默认为 false。填 true 代表清空 MetaData，清空后基于此新创建的云主机将不会关联自定义的 Metadata。
        /// </summary>
        [JsonProperty("ClearMetadata")]
        public bool? ClearMetadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "ClearDataDisks", this.ClearDataDisks);
            this.SetParamSimple(map, prefix + "ClearHostNameSettings", this.ClearHostNameSettings);
            this.SetParamSimple(map, prefix + "ClearInstanceNameSettings", this.ClearInstanceNameSettings);
            this.SetParamSimple(map, prefix + "ClearDisasterRecoverGroupIds", this.ClearDisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "ClearInstanceTags", this.ClearInstanceTags);
            this.SetParamSimple(map, prefix + "ClearMetadata", this.ClearMetadata);
        }
    }
}

