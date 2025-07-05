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

    public class DBBackup : AbstractModel
    {
        
        /// <summary>
        /// 备份文件唯一标识
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 文件生成的开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 文件生成的结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 文件大小(K)
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 策略（0-实例备份；1-多库备份）
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// 类型（0-定时）
        /// </summary>
        [JsonProperty("Way")]
        public long? Way{ get; set; }

        /// <summary>
        /// 备份方式（1-完整）
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 状态（1-创建中；2-成功；3-失败）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// DB列表
        /// </summary>
        [JsonProperty("DbList")]
        public string[] DbList{ get; set; }

        /// <summary>
        /// 内网下载地址
        /// </summary>
        [JsonProperty("InternalAddr")]
        public string InternalAddr{ get; set; }

        /// <summary>
        /// 外网下载地址
        /// </summary>
        [JsonProperty("ExternalAddr")]
        public string ExternalAddr{ get; set; }

        /// <summary>
        /// 备份集ID
        /// </summary>
        [JsonProperty("SetId")]
        public string SetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "Way", this.Way);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "DbList.", this.DbList);
            this.SetParamSimple(map, prefix + "InternalAddr", this.InternalAddr);
            this.SetParamSimple(map, prefix + "ExternalAddr", this.ExternalAddr);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
        }
    }
}

