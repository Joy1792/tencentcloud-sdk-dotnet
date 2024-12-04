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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicDetail : AbstractModel
    {
        
        /// <summary>
        /// 主题名
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 主题Id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 分区数
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// topic副本数  最小值 1,最大值 3
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public long? ReplicaNum{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 是否开启ip鉴权白名单，true表示开启，false表示不开启
        /// </summary>
        [JsonProperty("EnableWhiteList")]
        public bool? EnableWhiteList{ get; set; }

        /// <summary>
        /// ip白名单中ip个数
        /// </summary>
        [JsonProperty("IpWhiteListCount")]
        public long? IpWhiteListCount{ get; set; }

        /// <summary>
        /// 数据备份cos bucket: 转存到cos 的bucket地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForwardCosBucket")]
        public string ForwardCosBucket{ get; set; }

        /// <summary>
        /// 数据备份cos 状态： 1 不开启数据备份，0 开启数据备份
        /// </summary>
        [JsonProperty("ForwardStatus")]
        public long? ForwardStatus{ get; set; }

        /// <summary>
        /// 数据备份到cos的周期频率
        /// </summary>
        [JsonProperty("ForwardInterval")]
        public long? ForwardInterval{ get; set; }

        /// <summary>
        /// 高级配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Config")]
        public Config Config{ get; set; }

        /// <summary>
        /// 消息保留时间配置(用于动态配置变更记录)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetentionTimeConfig")]
        public TopicRetentionTimeConfigRsp RetentionTimeConfig{ get; set; }

        /// <summary>
        /// 0:正常，1：已删除，2：删除中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EnableWhiteList", this.EnableWhiteList);
            this.SetParamSimple(map, prefix + "IpWhiteListCount", this.IpWhiteListCount);
            this.SetParamSimple(map, prefix + "ForwardCosBucket", this.ForwardCosBucket);
            this.SetParamSimple(map, prefix + "ForwardStatus", this.ForwardStatus);
            this.SetParamSimple(map, prefix + "ForwardInterval", this.ForwardInterval);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "RetentionTimeConfig.", this.RetentionTimeConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

