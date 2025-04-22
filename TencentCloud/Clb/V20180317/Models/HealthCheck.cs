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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheck : AbstractModel
    {
        
        /// <summary>
        /// 是否开启健康检查：1（开启）、0（关闭）。
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// 健康检查的响应超时时间，可选值：2~60，默认值：2，单位：秒。响应超时时间要小于检查间隔时间。
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// 健康检查探测间隔时间，默认值：5，IPv4 CLB实例的取值范围为：2-300，IPv6 CLB 实例的取值范围为：5-300。单位：秒。
        /// 说明：部分老旧 IPv4 CLB实例的取值范围为：5-300。
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// 健康阈值，默认值：3，表示当连续探测三次健康则表示该转发正常，可选值：2~10，单位：次。
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// 不健康阈值，默认值：3，表示当连续探测三次不健康则表示该转发异常，可选值：2~10，单位：次。
        /// </summary>
        [JsonProperty("UnHealthNum")]
        public long? UnHealthNum{ get; set; }

        /// <summary>
        /// 健康检查状态码（仅适用于HTTP/HTTPS转发规则、TCP监听器的HTTP健康检查方式）。可选值：1~31，默认 31。
        /// 1 表示探测后返回值 1xx 代表健康，2 表示返回 2xx 代表健康，4 表示返回 3xx 代表健康，8 表示返回 4xx 代表健康，16 表示返回 5xx 代表健康。若希望多种返回码都可代表健康，则将相应的值相加。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCode")]
        public long? HttpCode{ get; set; }

        /// <summary>
        /// 健康检查路径（仅适用于HTTP/HTTPS转发规则、TCP监听器的HTTP健康检查方式）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// 健康检查域名（仅适用于HTTP/HTTPS监听器和TCP监听器的HTTP健康检查方式。针对TCP监听器，当使用HTTP健康检查方式时，该参数为必填项）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCheckDomain")]
        public string HttpCheckDomain{ get; set; }

        /// <summary>
        /// 健康检查方法（仅适用于HTTP/HTTPS转发规则、TCP监听器的HTTP健康检查方式），默认值：HEAD，可选值HEAD或GET。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCheckMethod")]
        public string HttpCheckMethod{ get; set; }

        /// <summary>
        /// 自定义探测相关参数。健康检查端口，默认为后端服务的端口，除非您希望指定特定端口，否则建议留空。（仅适用于TCP/UDP监听器）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckPort")]
        public long? CheckPort{ get; set; }

        /// <summary>
        /// 自定义探测相关参数。健康检查协议CheckType的值取CUSTOM时，必填此字段，代表健康检查的输入格式，可取值：HEX或TEXT；取值为HEX时，SendContext和RecvContext的字符只能在0123456789ABCDEF中选取且长度必须是偶数位。（仅适用于TCP/UDP监听器）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// 自定义探测相关参数。健康检查协议CheckType的值取CUSTOM时，必填此字段，代表健康检查发送的请求内容，只允许ASCII可见字符，最大长度限制500。（仅适用于TCP/UDP监听器）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// 自定义探测相关参数。健康检查协议CheckType的值取CUSTOM时，必填此字段，代表健康检查返回的结果，只允许ASCII可见字符，最大长度限制500。（仅适用于TCP/UDP监听器）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// 健康检查使用的协议。取值 TCP | HTTP | HTTPS | GRPC | PING | CUSTOM，UDP监听器支持PING/CUSTOM，TCP监听器支持TCP/HTTP/CUSTOM，TCP_SSL/QUIC监听器支持TCP/HTTP，HTTP规则支持HTTP/GRPC，HTTPS规则支持HTTP/HTTPS/GRPC。HTTP监听器默认值为HTTP;TCP、TCP_SSL、QUIC监听器默认值为TCP;UDP监听器默认为PING;HTTPS监听器的CheckType默认值与后端转发协议一致。
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// HTTP版本。健康检查协议CheckType的值取HTTP时，必传此字段，代表后端服务的HTTP版本：HTTP/1.0、HTTP/1.1；（仅适用于TCP监听器）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }

        /// <summary>
        /// 健康检查源IP类型：0（使用LB的VIP作为源IP），1（使用100.64网段IP作为源IP）。
        /// </summary>
        [JsonProperty("SourceIpType")]
        public long? SourceIpType{ get; set; }

        /// <summary>
        /// GRPC健康检查状态码（仅适用于后端转发协议为GRPC的规则）。默认值为 12，可输入值为数值、多个数值、或者范围，例如 20 或 20,25 或 0-99
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtendedCode")]
        public string ExtendedCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnHealthNum", this.UnHealthNum);
            this.SetParamSimple(map, prefix + "HttpCode", this.HttpCode);
            this.SetParamSimple(map, prefix + "HttpCheckPath", this.HttpCheckPath);
            this.SetParamSimple(map, prefix + "HttpCheckDomain", this.HttpCheckDomain);
            this.SetParamSimple(map, prefix + "HttpCheckMethod", this.HttpCheckMethod);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
            this.SetParamSimple(map, prefix + "SourceIpType", this.SourceIpType);
            this.SetParamSimple(map, prefix + "ExtendedCode", this.ExtendedCode);
        }
    }
}

