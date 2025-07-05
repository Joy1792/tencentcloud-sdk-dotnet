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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRuleAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 转发规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 监听器源站访问策略，其中：rr表示轮询；wrr表示加权轮询；lc表示最小连接数；lrtt表示最小时延。
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 源站健康检查开关，其中：
        /// 1，开启；
        /// 0，关闭。
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// 健康检查配置参数
        /// </summary>
        [JsonProperty("CheckParams")]
        public RuleCheckParams CheckParams{ get; set; }

        /// <summary>
        /// 转发规则路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 加速通道转发到源站的协议类型，支持：default, HTTP和HTTPS。
        /// 当ForwardProtocol=default时，表示使用对应监听器的ForwardProtocol。
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// 回源Host。加速通道转发到源站的请求中携带的host。
        /// 当ForwardHost=default时，使用规则的域名，其他情况为该字段所设置的值。
        /// </summary>
        [JsonProperty("ForwardHost")]
        public string ForwardHost{ get; set; }

        /// <summary>
        /// 服务器名称指示（ServerNameIndication，简称SNI）开关。ON表示开启，OFF表示关闭。
        /// </summary>
        [JsonProperty("ServerNameIndicationSwitch")]
        public string ServerNameIndicationSwitch{ get; set; }

        /// <summary>
        /// 服务器名称指示（ServerNameIndication，简称SNI），当SNI开关打开时，该字段必填。
        /// </summary>
        [JsonProperty("ServerNameIndication")]
        public string ServerNameIndication{ get; set; }

        /// <summary>
        /// HTTP强制跳转HTTPS。输入当前规则对应的域名与地址。
        /// </summary>
        [JsonProperty("ForcedRedirect")]
        public string ForcedRedirect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamObj(map, prefix + "CheckParams.", this.CheckParams);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "ForwardHost", this.ForwardHost);
            this.SetParamSimple(map, prefix + "ServerNameIndicationSwitch", this.ServerNameIndicationSwitch);
            this.SetParamSimple(map, prefix + "ServerNameIndication", this.ServerNameIndication);
            this.SetParamSimple(map, prefix + "ForcedRedirect", this.ForcedRedirect);
        }
    }
}

