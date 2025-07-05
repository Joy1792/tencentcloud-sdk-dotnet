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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetMessageQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 消息队列类型 1-CMQ; 2-Ckafka
        /// </summary>
        [JsonProperty("MsgQueueType")]
        public ulong? MsgQueueType{ get; set; }

        /// <summary>
        /// 消息类型,整型值（0-31）之间以“,”分隔
        /// 0.设备在线状态变更
        /// 1.常亮属性(ProConst)变更
        /// 2.可写属性(ProWritable)变更
        /// 3.只读属性(ProReadonly)变更
        /// 4.设备控制(Action)
        /// 5.设备事件(Event)
        /// 6.系统事件(System)
        /// </summary>
        [JsonProperty("MsgType")]
        public string MsgType{ get; set; }

        /// <summary>
        /// 消息队列主题，不超过32字符
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// kafka消息队列的实例名，不超过64字符
        /// </summary>
        [JsonProperty("Instance")]
        public string Instance{ get; set; }

        /// <summary>
        /// 消息地域，不超过32字符
        /// </summary>
        [JsonProperty("MsgRegion")]
        public string MsgRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "MsgQueueType", this.MsgQueueType);
            this.SetParamSimple(map, prefix + "MsgType", this.MsgType);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Instance", this.Instance);
            this.SetParamSimple(map, prefix + "MsgRegion", this.MsgRegion);
        }
    }
}

