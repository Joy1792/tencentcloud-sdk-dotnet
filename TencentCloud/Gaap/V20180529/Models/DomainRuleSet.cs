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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainRuleSet : AbstractModel
    {
        
        /// <summary>
        /// 转发规则域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 该域名对应的转发规则列表。
        /// </summary>
        [JsonProperty("RuleSet")]
        public RuleInfo[] RuleSet{ get; set; }

        /// <summary>
        /// 该域名对应的服务器证书ID，值为default时，表示使用默认证书（监听器配置的证书）。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 该域名对应服务器证书名称。
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// 该域名对应的客户端证书ID，值为default时，表示使用默认证书（监听器配置的证书）。
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// 该域名对应客户端证书名称。
        /// </summary>
        [JsonProperty("ClientCertificateAlias")]
        public string ClientCertificateAlias{ get; set; }

        /// <summary>
        /// 该域名对应基础认证配置ID。
        /// </summary>
        [JsonProperty("BasicAuthConfId")]
        public string BasicAuthConfId{ get; set; }

        /// <summary>
        /// 基础认证开关，其中：
        /// 0，表示未开启；
        /// 1，表示已开启。
        /// </summary>
        [JsonProperty("BasicAuth")]
        public long? BasicAuth{ get; set; }

        /// <summary>
        /// 该域名对应基础认证配置名称。
        /// </summary>
        [JsonProperty("BasicAuthConfAlias")]
        public string BasicAuthConfAlias{ get; set; }

        /// <summary>
        /// 该域名对应源站认证证书ID。
        /// </summary>
        [JsonProperty("RealServerCertificateId")]
        public string RealServerCertificateId{ get; set; }

        /// <summary>
        /// 源站认证开关，其中：
        /// 0，表示未开启；
        /// 1，表示已开启。
        /// </summary>
        [JsonProperty("RealServerAuth")]
        public long? RealServerAuth{ get; set; }

        /// <summary>
        /// 该域名对应源站认证证书名称。
        /// </summary>
        [JsonProperty("RealServerCertificateAlias")]
        public string RealServerCertificateAlias{ get; set; }

        /// <summary>
        /// 该域名对应通道认证证书ID。
        /// </summary>
        [JsonProperty("GaapCertificateId")]
        public string GaapCertificateId{ get; set; }

        /// <summary>
        /// 通道认证开关，其中：
        /// 0，表示未开启；
        /// 1，表示已开启。
        /// </summary>
        [JsonProperty("GaapAuth")]
        public long? GaapAuth{ get; set; }

        /// <summary>
        /// 该域名对应通道认证证书名称。
        /// </summary>
        [JsonProperty("GaapCertificateAlias")]
        public string GaapCertificateAlias{ get; set; }

        /// <summary>
        /// 源站认证域名。
        /// </summary>
        [JsonProperty("RealServerCertificateDomain")]
        public string RealServerCertificateDomain{ get; set; }

        /// <summary>
        /// 多客户端证书时，返回多个证书的id和别名
        /// </summary>
        [JsonProperty("PolyClientCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyClientCertificateAliasInfo{ get; set; }

        /// <summary>
        /// 多源站证书时，返回多个证书的id和别名
        /// </summary>
        [JsonProperty("PolyRealServerCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyRealServerCertificateAliasInfo{ get; set; }

        /// <summary>
        /// 域名的状态。
        /// 0表示运行中，
        /// 1表示变更中，
        /// 2表示删除中。
        /// </summary>
        [JsonProperty("DomainStatus")]
        public ulong? DomainStatus{ get; set; }

        /// <summary>
        /// 封禁解封状态：BANNED表示已封禁，RECOVER表示已解封或未封禁，BANNING表示封禁中，RECOVERING表示解封中，BAN_FAILED表示封禁失败，RECOVER_FAILED表示解封失败。
        /// </summary>
        [JsonProperty("BanStatus")]
        public string BanStatus{ get; set; }

        /// <summary>
        /// Http3特性标识，其中：
        /// 0表示关闭；
        /// 1表示启用。
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }

        /// <summary>
        /// 是否为默认域名
        /// </summary>
        [JsonProperty("IsDefaultServer")]
        public bool? IsDefaultServer{ get; set; }

        /// <summary>
        /// TLS套件包
        /// </summary>
        [JsonProperty("TLSCiphers")]
        public string TLSCiphers{ get; set; }

        /// <summary>
        /// TLS版本
        /// </summary>
        [JsonProperty("TLSSupportVersion")]
        public string[] TLSSupportVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "RuleSet.", this.RuleSet);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamSimple(map, prefix + "ClientCertificateAlias", this.ClientCertificateAlias);
            this.SetParamSimple(map, prefix + "BasicAuthConfId", this.BasicAuthConfId);
            this.SetParamSimple(map, prefix + "BasicAuth", this.BasicAuth);
            this.SetParamSimple(map, prefix + "BasicAuthConfAlias", this.BasicAuthConfAlias);
            this.SetParamSimple(map, prefix + "RealServerCertificateId", this.RealServerCertificateId);
            this.SetParamSimple(map, prefix + "RealServerAuth", this.RealServerAuth);
            this.SetParamSimple(map, prefix + "RealServerCertificateAlias", this.RealServerCertificateAlias);
            this.SetParamSimple(map, prefix + "GaapCertificateId", this.GaapCertificateId);
            this.SetParamSimple(map, prefix + "GaapAuth", this.GaapAuth);
            this.SetParamSimple(map, prefix + "GaapCertificateAlias", this.GaapCertificateAlias);
            this.SetParamSimple(map, prefix + "RealServerCertificateDomain", this.RealServerCertificateDomain);
            this.SetParamArrayObj(map, prefix + "PolyClientCertificateAliasInfo.", this.PolyClientCertificateAliasInfo);
            this.SetParamArrayObj(map, prefix + "PolyRealServerCertificateAliasInfo.", this.PolyRealServerCertificateAliasInfo);
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
            this.SetParamSimple(map, prefix + "IsDefaultServer", this.IsDefaultServer);
            this.SetParamSimple(map, prefix + "TLSCiphers", this.TLSCiphers);
            this.SetParamArraySimple(map, prefix + "TLSSupportVersion.", this.TLSSupportVersion);
        }
    }
}

