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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，形如：postgres-6bwgamo3。可通过[DescribeDBInstances](https://cloud.tencent.com/document/api/409/16773)接口获取
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 修改后的实例内存大小，单位GiB。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 修改后的实例磁盘大小，单位GiB。该参数的设置步长为10。
        /// </summary>
        [JsonProperty("Storage")]
        public ulong? Storage{ get; set; }

        /// <summary>
        /// 是否自动使用代金券：
        /// <li>0：否</li>
        /// <li>1：是</li>
        /// 默认值：0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表，目前仅支持指定一张代金券。
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// 活动ID。
        /// </summary>
        [JsonProperty("ActivityId")]
        public ulong? ActivityId{ get; set; }

        /// <summary>
        /// 指定实例配置完成变更后的切换时间。
        /// <li>0：立即切换 </li>
        /// <li>1：指定时间切换</li>
        /// <li>2：维护时间窗口内</li>切换
        /// 默认值：0 
        /// </summary>
        [JsonProperty("SwitchTag")]
        public ulong? SwitchTag{ get; set; }

        /// <summary>
        /// 切换开始时间，时间格式：HH:MM:SS，例如：01:00:00。当SwitchTag为0或2时，该参数失效。
        /// </summary>
        [JsonProperty("SwitchStartTime")]
        public string SwitchStartTime{ get; set; }

        /// <summary>
        /// 切换截止时间，时间格式：HH:MM:SS，例如：01:30:00。当SwitchTag为0或2时，该参数失效。
        /// </summary>
        [JsonProperty("SwitchEndTime")]
        public string SwitchEndTime{ get; set; }

        /// <summary>
        /// 修改后的实例CPU大小，单位Core。不填写该参数时，默认根据Memory确定Cpu大小。如Memory为2，支持的规格有1核2GiB，则不传入Cpu时，Cpu默认为1。
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "SwitchTag", this.SwitchTag);
            this.SetParamSimple(map, prefix + "SwitchStartTime", this.SwitchStartTime);
            this.SetParamSimple(map, prefix + "SwitchEndTime", this.SwitchEndTime);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
        }
    }
}

