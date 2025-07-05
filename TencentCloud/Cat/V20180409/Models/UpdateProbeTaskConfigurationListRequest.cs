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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateProbeTaskConfigurationListRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务 ID，如task-n1wchki8
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// 拨测节点，如10001，详细地区运营商拨测编号请联系云拨测。
        /// </summary>
        [JsonProperty("Nodes")]
        public string[] Nodes{ get; set; }

        /// <summary>
        /// 拨测间隔，如30，单位为分钟。
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// 拨测参数，详细参数配置可参考云拨测官网文档。
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 定时任务cron表达式
        /// </summary>
        [JsonProperty("Cron")]
        public string Cron{ get; set; }

        /// <summary>
        /// 预付费套餐id
        /// 需要与taskId对应
        /// </summary>
        [JsonProperty("ResourceIDs")]
        public string[] ResourceIDs{ get; set; }

        /// <summary>
        /// 拨测节点的IP类型，0-不限，1-IPv4，2-IPv6
        /// </summary>
        [JsonProperty("NodeIpType")]
        public long? NodeIpType{ get; set; }

        /// <summary>
        /// 批量任务名-地址
        /// </summary>
        [JsonProperty("BatchTasks")]
        public ProbeTaskBasicConfiguration[] BatchTasks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamArraySimple(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "Cron", this.Cron);
            this.SetParamArraySimple(map, prefix + "ResourceIDs.", this.ResourceIDs);
            this.SetParamSimple(map, prefix + "NodeIpType", this.NodeIpType);
            this.SetParamArrayObj(map, prefix + "BatchTasks.", this.BatchTasks);
        }
    }
}

