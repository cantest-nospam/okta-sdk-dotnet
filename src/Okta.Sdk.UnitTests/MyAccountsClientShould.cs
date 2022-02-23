// <copyright file="MyAccountsClientShould.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Okta.Sdk.UnitTests.Internal;
using Xunit;

namespace Okta.Sdk.UnitTests
{
    public class MyAccountsClientShould
    {
        [Fact]
        public async Task AddNewEmail()
        {
            var rawResponse = @"{
                                  ""id"": ""e2a84ed3cc538f75457596faa74a4532"",
                                  ""status"": ""UNVERIFIED"",
                                  ""roles"": [
                                    ""PRIMARY""
                                  ],
                                  ""profile"": {
                                    ""email"": ""email@example.com""
                                  },
                                  ""_links"": {
                                    ""self"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET"",
                                          ""DELETE""
                                        ]
                                      }
                                    },
                                    ""challenge"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""verify"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.IDseIErVSEiFlLyAbzSp5Q/verify"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""poll"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.IDseIErVSEiFlLyAbzSp5Q"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET""
                                        ]
                                      }
                                    }
                                  }
                                }";

            var mockRequestExecutor = new MockedStringRequestExecutor(rawResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.AddNewEmailAsync(
                new AddEmailRequest
                {
                    Profile = new EmailProfile
                    {
                        Email = "email@example.com",
                    },
                    SendEmail = true,
                    State = "foo",
                    //Role = "PRIMARY"
                });

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/emails");
            response.Id.Should().Be("e2a84ed3cc538f75457596faa74a4532");
            // Missing enum?
            response.Status.Should().Be("UNVERIFIED");
            response.Profile.Email.Should().Be("email@example.com");
            response.Roles.Should().Contain("PRIMARY");
        }

        [Fact]
        public async Task ListEmails()
        {
            var rawResponse = @"[
                    {
                      ""id"": ""69dca29c2d8dbb0dca14395ccdb92317"",
                      ""status"": ""VERIFIED"",
                      ""roles"": [
                        ""PRIMARY""
                      ],
                      ""profile"": {
                        ""email"": ""email@example.com""
                      },
                      ""_links"": {
                        ""self"": {
                          ""href"": ""https://example.okta.com/idp/myaccount/emails/69dca29c2d8dbb0dca14395ccdb92317"",
                          ""hints"": {
                            ""allow"": [
                              ""GET""
                            ]
                          }
                        },
                        ""challenge"": {
                          ""href"": ""https://example.okta.com/idp/myaccount/emails/69dca29c2d8dbb0dca14395ccdb92317/challenge"",
                          ""hints"": {
                            ""allow"": [
                              ""POST""
                            ]
                          }
                        }
                      }
                    },
                    {
                      ""id"": ""e2a84ed3cc538f75457596faa74a4532"",
                      ""status"": ""UNVERIFIED"",
                      ""roles"": [
                        ""PRIMARY""
                      ],
                      ""profile"": {
                        ""email"": ""email2@company.com""
                      },
                      ""_links"": {
                        ""self"": {
                          ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532"",
                          ""hints"": {
                            ""allow"": [
                              ""GET"",
                              ""DELETE""
                            ]
                          }
                        },
                        ""challenge"": {
                          ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge"",
                          ""hints"": {
                            ""allow"": [
                              ""POST""
                            ]
                          }
                        },
                        ""verify"": {
                          ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.IDseIErVSEiFlLyAbzSp5Q/verify"",
                          ""hints"": {
                            ""allow"": [
                              ""POST""
                            ]
                          }
                        },
                        ""poll"": {
                          ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.IDseIErVSEiFlLyAbzSp5Q"",
                          ""hints"": {
                            ""allow"": [
                              ""GET""
                            ]
                          }
                        }
                      }
                    }
                  ]";

            var mockRequestExecutor = new MockedStringRequestExecutor(rawResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.ListEmails().ToListAsync();

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/emails");
            response.Should().HaveCount(2);
            response.FirstOrDefault(x => x.Id == "69dca29c2d8dbb0dca14395ccdb92317").Should().NotBeNull();
        }

        [Fact]
        public async Task GetEmail()
        {
            var rawResponse = @"{
                                  ""id"": ""e2a84ed3cc538f75457596faa74a4532"",
                                  ""status"": ""UNVERIFIED"",
                                  ""roles"": [
                                    ""PRIMARY""
                                  ],
                                  ""profile"": {
                                    ""email"": ""email@example.com""
                                  },
                                  ""_links"": {
                                    ""self"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET"",
                                          ""DELETE""
                                        ]
                                      }
                                    },
                                    ""challenge"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""verify"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.IDseIErVSEiFlLyAbzSp5Q/verify"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""poll"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.IDseIErVSEiFlLyAbzSp5Q"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET""
                                        ]
                                      }
                                    }
                                  }
                                }";

            var mockRequestExecutor = new MockedStringRequestExecutor(rawResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.ListEmailAsync("e2a84ed3cc538f75457596faa74a4532");

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532");
            response.Id.Should().Be("e2a84ed3cc538f75457596faa74a4532");
            // Missing enum?
            response.Status.Should().Be("UNVERIFIED");
            response.Profile.Email.Should().Be("email@example.com");
            response.Roles.Should().Contain("PRIMARY");
        }

        [Fact]
        public async Task DeleteEmail()
        {
            var mockRequestExecutor = new MockedStringRequestExecutor("{}");
            var client = new TestableOktaClient(mockRequestExecutor);

            await client.MyAccounts.DeleteEmailAsync("e2a84ed3cc538f75457596faa74a4532");

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532");
        }

        [Fact]
        public async Task VerifyEmailOtp()
        {
            var mockRequestExecutor = new MockedStringRequestExecutor("{}");
            var client = new TestableOktaClient(mockRequestExecutor);

            await client.MyAccounts.VerifyEmailOtpAsync(new VerifyEmailOTP { VerificationCode = "12345" }, "foo", "bar");

            var expectedBody = @"{""verificationCode"":""12345""}";
            mockRequestExecutor.ReceivedBody.Trim().Should().Be(expectedBody.Trim());
            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/emails/foo/challenge/bar/verify");
        }

        [Fact]
        public async Task SendEmailChallenge()
        {
            var mockResponse = @"{
                                  ""id"": ""foo"",
                                  ""status"": ""UNVERIFIED"",
                                  ""expiresAt"": ""2022-02-01T00:19:08.220Z"",
                                  ""profile"": {
                                    ""email"": ""email@example.com""
                                  },
                                  ""_links"": {
                                    ""verify"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.2wdtXPtmS0WpKq4bnjlYIw/verify"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""poll"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/e2a84ed3cc538f75457596faa74a4532/challenge/myaccount.2wdtXPtmS0WpKq4bnjlYIw"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET""
                                        ]
                                      }
                                    }
                                  }
                                }";
            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.SendEmailChallengeAsync(new EmailChallengeRequest { State = "myState" }, "foo");

            var expectedBody = @"{""state"":""myState""}";
            mockRequestExecutor.ReceivedBody.Trim().Should().Be(expectedBody.Trim());
            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/emails/foo/challenge");

            response.Id.Should().Be("foo");
            response.Status.Should().Be("UNVERIFIED");
            response.Profile.Email.Should().Be("email@example.com");
        }

        [Fact]
        public async Task PollEmailMagicLink()
        {
            var mockResponse = @"{
                                  ""id"": ""myaccount.DDvNA6XORA2dIfB894o32g"",
                                  ""status"": ""UNVERIFIED"",
                                  ""expiresAt"": ""2022-02-01T00:41:25.497Z"",
                                  ""profile"": {
                                    ""email"": ""email@example.com""
                                  },
                                  ""_links"": {
                                    ""verify"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/da03e945d44d8b714da2b9fded39e851/challenge/myaccount.DDvNA6XORA2dIfB894o32g/verify"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""poll"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/emails/da03e945d44d8b714da2b9fded39e851/challenge/myaccount.DDvNA6XORA2dIfB894o32g"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET""
                                        ]
                                      }
                                    }
                                  }
                                }";
            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.PollForEmailMagicLinkAsync("foo", "bar");

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/emails/foo/challenge/bar");
            response.GetProperty<Resource>("_links")
                .GetProperty<Resource>("poll")
                .GetProperty<string>("href")
                .Should()
                .Be("https://example.okta.com/idp/myaccount/emails/da03e945d44d8b714da2b9fded39e851/challenge/myaccount.DDvNA6XORA2dIfB894o32g");
        }

        [Fact]
        public async Task ListPhones()
        {
            var mockResponse = @"[
                                  {
                                    ""id"": ""sms10ltpSdwXJCem80g4"",
                                    ""status"": ""VERIFIED"",
                                    ""profile"": {
                                      ""phoneNumber"": ""+13333333333""
                                    },
                                    ""_links"": {
                                      ""self"": {
                                        ""href"": ""https://example.okta.com/idp/myaccount/phones/sms10ltpSdwXJCem80g4"",
                                        ""hints"": {
                                          ""allow"": [
                                            ""GET"",
                                            ""DELETE""
                                          ]
                                        }
                                      },
                                      ""challenge"": {
                                        ""href"": ""https://example.okta.com/idp/myaccount/phones/sms10ltpSdwXJCem80g4/challenge"",
                                        ""hints"": {
                                          ""allow"": [
                                            ""POST""
                                          ]
                                        }
                                      },
                                      ""verify"": {
                                        ""href"": ""https://example.okta.com/idp/myaccount/phones/sms10ltpSdwXJCem80g4/verify"",
                                        ""hints"": {
                                          ""allow"": [
                                            ""POST""
                                          ]
                                        }
                                      }
                                    }
                                  },
                                  {
                                    ""id"": ""sms18vrvVDDmi4Qlz0g4"",
                                    ""status"": ""UNVERIFIED"",
                                    ""profile"": {
                                      ""phoneNumber"": ""+12222222222""
                                    },
                                    ""_links"": {
                                      ""self"": {
                                        ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vrvVDDmi4Qlz0g4"",
                                        ""hints"": {
                                          ""allow"": [
                                            ""GET"",
                                            ""DELETE""
                                          ]
                                        }
                                      },
                                      ""challenge"": {
                                        ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vrvVDDmi4Qlz0g4/challenge"",
                                        ""hints"": {
                                          ""allow"": [
                                            ""POST""
                                          ]
                                        }
                                      },
                                      ""verify"": {
                                        ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vrvVDDmi4Qlz0g4/verify"",
                                        ""hints"": {
                                          ""allow"": [
                                            ""POST""
                                          ]
                                        }
                                      }
                                    }
                                  }
                                ]";
            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.ListPhones().ToListAsync();

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/phones");
            response.Should().HaveCount(2);
            response.FirstOrDefault(x => x.Profile.PhoneNumber == "+12222222222").Should().NotBeNull();
        }

        [Fact]
        public async Task AddNewPhone()
        {
            var mockResponse = @"{
                                  ""id"": ""foo"",
                                  ""status"": ""UNVERIFIED"",
                                  ""profile"": {
                                    ""phoneNumber"": ""+1(444)444-4444""
                                  },
                                  ""_links"": {
                                    ""self"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vtfKgzqDhNqP0g4"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET"",
                                          ""DELETE""
                                        ]
                                      }
                                    },
                                    ""challenge"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vtfKgzqDhNqP0g4/challenge"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""verify"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vtfKgzqDhNqP0g4/verify"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    }
                                  }
                                }";
            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.AddPhoneAsync(
                new AddPhoneRequest
                {
                    Profile = new PhoneProfile { PhoneNumber = "+1(444)444-4444" },
                    Method = PhoneMethod.Sms,
                    SendCode = true,
                });

            var expectedBody = @"{""profile"":{""phoneNumber"":""+1(444)444-4444""},""method"":""SMS"",""sendCode"":true}";
            mockRequestExecutor.ReceivedBody.Trim().Should().Be(expectedBody.Trim());
            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/phones");

            response.Id.Should().Be("foo");
            response.Status.Should().Be("UNVERIFIED");
            response.Profile.PhoneNumber.Should().Be("+1(444)444-4444");
        }

        [Fact]
        public async Task GetPhoneById()
        {
            var mockResponse = @"{
                                  ""id"": ""foo"",
                                  ""status"": ""UNVERIFIED"",
                                  ""profile"": {
                                    ""phoneNumber"": ""+1(444)444-4444""
                                  },
                                  ""_links"": {
                                    ""self"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vtfKgzqDhNqP0g4"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""GET"",
                                          ""DELETE""
                                        ]
                                      }
                                    },
                                    ""challenge"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vtfKgzqDhNqP0g4/challenge"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    },
                                    ""verify"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/phones/sms18vtfKgzqDhNqP0g4/verify"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""POST""
                                        ]
                                      }
                                    }
                                  }
                                }";
            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.GetPhoneAsync("foo");

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/phones/foo");

            response.Id.Should().Be("foo");
            response.Status.Should().Be("UNVERIFIED");
            response.Profile.PhoneNumber.Should().Be("+1(444)444-4444");
        }

        [Fact]
        public async Task DeletePhone()
        {
            var mockRequestExecutor = new MockedStringRequestExecutor("{}");
            var client = new TestableOktaClient(mockRequestExecutor);

            await client.MyAccounts.DeletePhoneAsync("foo");

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/phones/foo");
        }

        [Fact]
        public async Task SendPhoneChallenge()
        {
            var mockRequestExecutor = new MockedStringRequestExecutor("{}");
            var client = new TestableOktaClient(mockRequestExecutor);

            await client.MyAccounts.SendPhoneChallengeAsync(new PhoneChallengeRequest { Method = PhoneMethod.Sms }, "foo");

            var expectedBody = @"{""method"":""SMS""}";
            mockRequestExecutor.ReceivedBody.Trim().Should().Be(expectedBody.Trim());
            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/phones/foo/challenge");
        }

        [Fact]
        public async Task VerifyPhoneChallenge()
        {
            var mockRequestExecutor = new MockedStringRequestExecutor("{}");
            var client = new TestableOktaClient(mockRequestExecutor);

            await client.MyAccounts.VerifyPhoneChallengeAsync(new VerifyPhoneChallengeRequest { VerificationCode = "12345" }, "foo");

            var expectedBody = @"{""verificationCode"":""12345""}";
            mockRequestExecutor.ReceivedBody.Trim().Should().Be(expectedBody.Trim());
            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/phones/foo/verify");
        }

        [Fact]
        public async Task GetProfile()
        {
            var mockResponse = @"{
                                  ""createdAt"": ""2020-01-14T20:05:32.000Z"",
                                  ""modifiedAt"": ""2020-01-14T20:05:32.000Z"",
                                  ""profile"": {
                                    ""customBoolean"": false,
                                    ""foo"": ""bar"",
                                    ""login"": ""example@ex.ample.com"",
                                    ""mobilePhone"": ""+1(555)555-5555"",
                                    ""customInteger"": 42
                                  },
                                  ""_links"": {
                                    ""self"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/profile""
                                    },
                                    ""describedBy"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/profile/schema""
                                    }
                                  }
                                }";

            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.GetMyProfileAsync();

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/profile");
            response.Profile.Login.Should().Be("example@ex.ample.com");
            response.Profile.GetProperty<string>("mobilePhone").Should().Be("+1(555)555-5555");
            response.Profile.GetProperty<int?>("customInteger").Should().Be(42);
            response.Profile.GetProperty<bool?>("customBoolean").Should().BeFalse();
            response.Profile.GetProperty<string>("foo").Should().Be("bar");
        }

        [Fact]
        public async Task UpdateProfile()
        {
            var mockResponse = @"{
                                  ""createdAt"": ""2020-01-14T20:05:32.000Z"",
                                  ""modifiedAt"": ""2020-01-14T20:05:32.000Z"",
                                  ""profile"": {
                                    ""customBoolean"": false,
                                    ""foo"": ""bar"",
                                    ""login"": ""example@ex.ample.com"",
                                    ""mobilePhone"": ""+1(555)555-5555"",
                                    ""customInteger"": 42
                                  },
                                  ""_links"": {
                                    ""self"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/profile""
                                    },
                                    ""describedBy"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/profile/schema""
                                    }
                                  }
                                }";

            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.UpdateMyProfileAsync(
            new UpdateMyProfileRequest
            {
                Profile = new MyProfileProfile
                {
                    Login = "example@ex.ample.com",
                },
            });

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/profile");
            response.Profile.Login.Should().Be("example@ex.ample.com");
            response.Profile.GetProperty<string>("mobilePhone").Should().Be("+1(555)555-5555");
            response.Profile.GetProperty<int?>("customInteger").Should().Be(42);
            response.Profile.GetProperty<bool?>("customBoolean").Should().BeFalse();
            response.Profile.GetProperty<string>("foo").Should().Be("bar");
        }

        [Fact]
        public async Task GetMyProfileSchema()
        {
            var mockResponse = @"{
                                  ""properties"": {
                                    ""customBoolean"": {
                                      ""permissions"": {
                                        ""SELF"": ""READ_WRITE""
                                      },
                                      ""title"": ""customBoolean"",
                                      ""type"": ""boolean""
                                    },
                                    ""foo"": {
                                      ""permissions"": {
                                        ""SELF"": ""READ_ONLY""
                                      },
                                      ""title"": ""foo"",
                                      ""type"": ""string""
                                    },
                                    ""login"": {
                                      ""maxLength"": 100,
                                      ""minLength"": 5,
                                      ""permissions"": {
                                        ""SELF"": ""READ_ONLY""
                                      },
                                      ""required"": true,
                                      ""title"": ""Username"",
                                      ""type"": ""string""
                                    },
                                    ""mobilePhone"": {
                                      ""maxLength"": 100,
                                      ""permissions"": {
                                        ""SELF"": ""READ_WRITE""
                                      },
                                      ""title"": ""Mobile phone"",
                                      ""type"": ""string""
                                    },
                                    ""customInteger"": {
                                      ""permissions"": {
                                        ""SELF"": ""READ_WRITE""
                                      },
                                      ""title"": ""customInteger"",
                                      ""type"": ""integer""
                                    }
                                  },
                                  ""_links"": {
                                    ""self"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/profile/schema""
                                    },
                                    ""user"": {
                                      ""href"": ""https://example.okta.com/idp/myaccount/profile""
                                    }
                                  }
                                }";

            var mockRequestExecutor = new MockedStringRequestExecutor(mockResponse);
            var client = new TestableOktaClient(mockRequestExecutor);

            var response = await client.MyAccounts.GetMyProfileSchemaAsync();

            mockRequestExecutor.ReceivedHref.Should().Be("/idp/myaccount/profile/schema");
            response.GetProperty<Resource>("properties")
                .GetProperty<Resource>("customBoolean")
                .GetProperty<string>("title")
                .Should().Be("customBoolean");

            response.GetProperty<Resource>("properties")
                .GetProperty<Resource>("customBoolean")
                .GetProperty<string>("type")
                .Should().Be("boolean");

            response.GetProperty<Resource>("properties")
                .GetProperty<Resource>("customBoolean")
                .GetProperty<Resource>("permissions")
                .GetProperty<string>("SELF")
                .Should().Be("READ_WRITE");
        }
    }
}
