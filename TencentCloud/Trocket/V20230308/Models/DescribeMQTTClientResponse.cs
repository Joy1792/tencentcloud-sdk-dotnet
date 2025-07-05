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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMQTTClientResponse : AbstractModel
    {
        
        /// <summary>
        /// 客户端唯一标识
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// 客户端网络地址
        /// </summary>
        [JsonProperty("ClientAddress")]
        public string ClientAddress{ get; set; }

        /// <summary>
        /// MQTT 协议版本，4 表示 MQTT 3.1.1
        /// </summary>
        [JsonProperty("ProtocolVersion")]
        public long? ProtocolVersion{ get; set; }

        /// <summary>
        /// 保持连接时间，单位：秒
        /// </summary>
        [JsonProperty("Keepalive")]
        public long? Keepalive{ get; set; }

        /// <summary>
        /// 连接状态，CONNECTED 已连接，DISCONNECTED 未连接
        /// </summary>
        [JsonProperty("ConnectionStatus")]
        public string ConnectionStatus{ get; set; }

        /// <summary>
        /// 客户端创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 上次建立连接时间
        /// </summary>
        [JsonProperty("ConnectTime")]
        public long? ConnectTime{ get; set; }

        /// <summary>
        /// 上次断开连接时间，仅对持久会话（cleanSession=false）并且客户端当前未连接时有意义
        /// </summary>
        [JsonProperty("DisconnectTime")]
        public long? DisconnectTime{ get; set; }

        /// <summary>
        /// 客户端的订阅列表
        /// </summary>
        [JsonProperty("MQTTClientSubscriptions")]
        public MQTTClientSubscription[] MQTTClientSubscriptions{ get; set; }

        /// <summary>
        /// 服务端到客户端的流量统计
        /// </summary>
        [JsonProperty("Inbound")]
        public StatisticsReport Inbound{ get; set; }

        /// <summary>
        /// 客户端到服务端的流量统计
        /// </summary>
        [JsonProperty("OutBound")]
        public StatisticsReport OutBound{ get; set; }

        /// <summary>
        /// cleansession标志
        /// </summary>
        [JsonProperty("CleanSession")]
        public bool? CleanSession{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientAddress", this.ClientAddress);
            this.SetParamSimple(map, prefix + "ProtocolVersion", this.ProtocolVersion);
            this.SetParamSimple(map, prefix + "Keepalive", this.Keepalive);
            this.SetParamSimple(map, prefix + "ConnectionStatus", this.ConnectionStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ConnectTime", this.ConnectTime);
            this.SetParamSimple(map, prefix + "DisconnectTime", this.DisconnectTime);
            this.SetParamArrayObj(map, prefix + "MQTTClientSubscriptions.", this.MQTTClientSubscriptions);
            this.SetParamObj(map, prefix + "Inbound.", this.Inbound);
            this.SetParamObj(map, prefix + "OutBound.", this.OutBound);
            this.SetParamSimple(map, prefix + "CleanSession", this.CleanSession);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

