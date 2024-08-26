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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Certificates : AbstractModel
    {
        
        /// <summary>
        /// 用户 UIN。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 证书来源。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 证书套餐类型：
        /// 2 = TrustAsia TLS RSA CA，3 = SecureSite 增强型企业版（EV Pro）， 4 = SecureSite 增强型（EV）， 5 = SecureSite 企业型专业版（OV Pro）， 6 = SecureSite 企业型（OV）， 7 = SecureSite 企业型（OV）通配符， 8 = Geotrust 增强型（EV）， 9 = Geotrust 企业型（OV）， 10 = Geotrust 企业型（OV）通配符， 11 = TrustAsia 域名型多域名 SSL 证书， 12 = TrustAsia 域名型（DV）通配符， 13 = TrustAsia 企业型通配符（OV）SSL 证书（D3）， 14 = TrustAsia 企业型（OV）SSL 证书（D3）， 15 = TrustAsia 企业型多域名 （OV）SSL 证书（D3）， 16 = TrustAsia 增强型 （EV）SSL 证书（D3）， 17 = TrustAsia 增强型多域名（EV）SSL 证书（D3）， 18 = GlobalSign 企业型（OV）SSL 证书， 19 = GlobalSign 企业型通配符 （OV）SSL 证书， 20 = GlobalSign 增强型 （EV）SSL 证书， 21 = TrustAsia 企业型通配符多域名（OV）SSL 证书（D3）， 22 = GlobalSign 企业型多域名（OV）SSL 证书， 23 = GlobalSign 企业型通配符多域名（OV）SSL 证书， 24 = GlobalSign 增强型多域名（EV）SSL 证书，25 = Wotrus 域名型证书，26 = Wotrus 域名型多域名证书，27 = Wotrus 域名型通配符证书，28 = Wotrus 企业型证书，29 = Wotrus 企业型多域名证书，30 = Wotrus 企业型通配符证书，31 = Wotrus 增强型证书，32 = Wotrus 增强型多域名证书，33 = Wotrus 国密域名型证书，34 = Wotrus 国密域名型多域名证书，35 = Wotrus 国密域名型通配符证书，37 = Wotrus 国密企业型证书，38 = Wotrus 国密企业型多域名证书，39 = Wotrus 国密企业型通配符证书，40 = Wotrus 国密增强型证书，41 = Wotrus 国密增强型多域名证书，42 = TrustAsia 域名型通配符多域名证书，43 = DNSPod-企业型(OV)SSL证书，44 = DNSPod-企业型(OV)通配符SSL证书，45 = DNSPod-企业型(OV)多域名SSL证书， 46 = DNSPod-增强型(EV)SSL证书，47 = DNSPod-增强型(EV)多域名SSL证书，48 = DNSPod-域名型(DV)SSL证书，49 = DNSPod-域名型(DV)通配符SSL证书，50 = DNSPod-域名型(DV)多域名SSL证书，51 = DNSPod（国密）-企业型(OV)SSL证书，52 = DNSPod（国密）-企业型(OV)通配符SSL证书，53 = DNSPod（国密）-企业型(OV)多域名SSL证书，54 = DNSPod（国密）-域名型(DV)SSL证书，55 = DNSPod（国密）-域名型(DV)通配符SSL证书， 56 = DNSPod（国密）-域名型(DV)多域名SSL证书，57 = SecureSite 企业型专业版多域名(OV Pro)，58 = SecureSite 企业型多域名(OV)，59 = SecureSite 增强型专业版多域名(EV Pro)，60 = SecureSite 增强型多域名(EV)，61 = Geotrust 增强型多域名(EV)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 证书类型：CA = 客户端证书，SVR = 服务器证书。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// 颁发者。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductZhName")]
        public string ProductZhName{ get; set; }

        /// <summary>
        /// 主域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 备注名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 状态。0：审核中，1：已通过，2：审核失败，3：已过期，4：验证方式为 DNS_AUTO 类型的证书， 已添加DNS记录，5：企业证书，待提交，6：订单取消中，7：已取消，8：已提交资料， 待上传确认函，9：证书吊销中，10：已吊销，11：重颁发中，12：待上传吊销确认函，13：免费证书待提交资料状态，14：已退款，
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 证书扩展信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateExtra")]
        public CertificateExtra CertificateExtra{ get; set; }

        /// <summary>
        /// 漏洞扫描状态：INACTIVE = 未开启，ACTIVE = 已开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulnerabilityStatus")]
        public string VulnerabilityStatus{ get; set; }

        /// <summary>
        /// 状态信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusMsg")]
        public string StatusMsg{ get; set; }

        /// <summary>
        /// 验证类型：DNS_AUTO = 自动DNS验证，DNS = 手动DNS验证，FILE = 文件验证，EMAIL = 邮件验证。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 证书生效时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// 证书过期时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// 证书有效期，单位（月）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// 创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 证书 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 证书包含的多个域名（包含主域名）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// 证书类型名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageTypeName")]
        public string PackageTypeName{ get; set; }

        /// <summary>
        /// 状态名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusName")]
        public string StatusName{ get; set; }

        /// <summary>
        /// 是否为 VIP 客户。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// 是否为 DV 版证书。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDv")]
        public bool? IsDv{ get; set; }

        /// <summary>
        /// 是否为泛域名证书。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsWildcard")]
        public bool? IsWildcard{ get; set; }

        /// <summary>
        /// 是否启用了漏洞扫描功能。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsVulnerability")]
        public bool? IsVulnerability{ get; set; }

        /// <summary>
        /// 是否可续费。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewAble")]
        public bool? RenewAble{ get; set; }

        /// <summary>
        /// 项目信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectInfo")]
        public ProjectInfo ProjectInfo{ get; set; }

        /// <summary>
        /// 关联的云资源，暂不可用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoundResource")]
        public string[] BoundResource{ get; set; }

        /// <summary>
        /// 是否可部署。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deployable")]
        public bool? Deployable{ get; set; }

        /// <summary>
        /// 标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// 是否已忽略到期通知
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsIgnore")]
        public bool? IsIgnore{ get; set; }

        /// <summary>
        /// 是否国密证书
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSM")]
        public bool? IsSM{ get; set; }

        /// <summary>
        /// 证书算法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// 上传CA证书的加密算法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CAEncryptAlgorithms")]
        public string[] CAEncryptAlgorithms{ get; set; }

        /// <summary>
        /// 上传CA证书的过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CAEndTimes")]
        public string[] CAEndTimes{ get; set; }

        /// <summary>
        /// 上传CA证书的通用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CACommonNames")]
        public string[] CACommonNames{ get; set; }

        /// <summary>
        /// 证书预审核信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreAuditInfo")]
        public PreAuditInfo PreAuditInfo{ get; set; }

        /// <summary>
        /// 是否自动续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 托管状态，0，托管中，5，资源替换中， 10， 托管完成， -1未托管 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostingStatus")]
        public long? HostingStatus{ get; set; }

        /// <summary>
        /// 托管完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostingCompleteTime")]
        public string HostingCompleteTime{ get; set; }

        /// <summary>
        /// 托管新证书ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostingRenewCertId")]
        public string HostingRenewCertId{ get; set; }

        /// <summary>
        /// 存在的续费证书ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasRenewOrder")]
        public string HasRenewOrder{ get; set; }

        /// <summary>
        /// 重颁发证书原证书是否删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplaceOriCertIsDelete")]
        public bool? ReplaceOriCertIsDelete{ get; set; }

        /// <summary>
        /// 是否即将过期， 证书即将到期的30天内为即将过期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsExpiring")]
        public bool? IsExpiring{ get; set; }

        /// <summary>
        /// DV证书添加验证截止时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DVAuthDeadline")]
        public string DVAuthDeadline{ get; set; }

        /// <summary>
        /// 域名验证通过时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidationPassedTime")]
        public string ValidationPassedTime{ get; set; }

        /// <summary>
        /// 证书关联的多域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertSANs")]
        public string[] CertSANs{ get; set; }

        /// <summary>
        /// 域名验证驳回信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AwaitingValidationMsg")]
        public string AwaitingValidationMsg{ get; set; }

        /// <summary>
        /// 是否允许下载
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowDownload")]
        public bool? AllowDownload{ get; set; }

        /// <summary>
        /// 证书域名是否全部在DNSPOD托管解析
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDNSPODResolve")]
        public bool? IsDNSPODResolve{ get; set; }

        /// <summary>
        /// 是否是权益点购买的证书
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPackage")]
        public bool? IsPackage{ get; set; }

        /// <summary>
        /// 是否存在私钥密码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyPasswordCustomFlag")]
        public bool? KeyPasswordCustomFlag{ get; set; }

        /// <summary>
        /// 支持下载的WEB服务器类型： nginx、apache、iis、tomcat、jks、root、other
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportDownloadType")]
        public SupportDownloadType SupportDownloadType{ get; set; }

        /// <summary>
        /// 证书吊销完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertRevokedTime")]
        public string CertRevokedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "ProductZhName", this.ProductZhName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "CertificateExtra.", this.CertificateExtra);
            this.SetParamSimple(map, prefix + "VulnerabilityStatus", this.VulnerabilityStatus);
            this.SetParamSimple(map, prefix + "StatusMsg", this.StatusMsg);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "CertBeginTime", this.CertBeginTime);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamArraySimple(map, prefix + "SubjectAltName.", this.SubjectAltName);
            this.SetParamSimple(map, prefix + "PackageTypeName", this.PackageTypeName);
            this.SetParamSimple(map, prefix + "StatusName", this.StatusName);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "IsDv", this.IsDv);
            this.SetParamSimple(map, prefix + "IsWildcard", this.IsWildcard);
            this.SetParamSimple(map, prefix + "IsVulnerability", this.IsVulnerability);
            this.SetParamSimple(map, prefix + "RenewAble", this.RenewAble);
            this.SetParamObj(map, prefix + "ProjectInfo.", this.ProjectInfo);
            this.SetParamArraySimple(map, prefix + "BoundResource.", this.BoundResource);
            this.SetParamSimple(map, prefix + "Deployable", this.Deployable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IsIgnore", this.IsIgnore);
            this.SetParamSimple(map, prefix + "IsSM", this.IsSM);
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamArraySimple(map, prefix + "CAEncryptAlgorithms.", this.CAEncryptAlgorithms);
            this.SetParamArraySimple(map, prefix + "CAEndTimes.", this.CAEndTimes);
            this.SetParamArraySimple(map, prefix + "CACommonNames.", this.CACommonNames);
            this.SetParamObj(map, prefix + "PreAuditInfo.", this.PreAuditInfo);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "HostingStatus", this.HostingStatus);
            this.SetParamSimple(map, prefix + "HostingCompleteTime", this.HostingCompleteTime);
            this.SetParamSimple(map, prefix + "HostingRenewCertId", this.HostingRenewCertId);
            this.SetParamSimple(map, prefix + "HasRenewOrder", this.HasRenewOrder);
            this.SetParamSimple(map, prefix + "ReplaceOriCertIsDelete", this.ReplaceOriCertIsDelete);
            this.SetParamSimple(map, prefix + "IsExpiring", this.IsExpiring);
            this.SetParamSimple(map, prefix + "DVAuthDeadline", this.DVAuthDeadline);
            this.SetParamSimple(map, prefix + "ValidationPassedTime", this.ValidationPassedTime);
            this.SetParamArraySimple(map, prefix + "CertSANs.", this.CertSANs);
            this.SetParamSimple(map, prefix + "AwaitingValidationMsg", this.AwaitingValidationMsg);
            this.SetParamSimple(map, prefix + "AllowDownload", this.AllowDownload);
            this.SetParamSimple(map, prefix + "IsDNSPODResolve", this.IsDNSPODResolve);
            this.SetParamSimple(map, prefix + "IsPackage", this.IsPackage);
            this.SetParamSimple(map, prefix + "KeyPasswordCustomFlag", this.KeyPasswordCustomFlag);
            this.SetParamObj(map, prefix + "SupportDownloadType.", this.SupportDownloadType);
            this.SetParamSimple(map, prefix + "CertRevokedTime", this.CertRevokedTime);
        }
    }
}

