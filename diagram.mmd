```mermaid


sequenceDiagram

    Actor u as User
    participant CampaignService
    participant ContactService
    participant BackgroundJobService
    participant SMSService
    participant Credit

    u ->> CampaignService: Create SMS Campaign (details, group of contacts)
    CampaignServsaice->>ContactService: Fetch contacts by group
    ContactService-->>CampaignService: Return list of contacts

    CampaignService->>BackgroundJobService: Schedule background job to send SMS
    BackgroundJobService-->>CampaignService: Background job scheduled

    CampaignService-->>u: Campaign created, SMS sending in progress (async)

    Note over BackgroundJobService: Background job running asynchronously

    BackgroundJobService->>SMSService: Send SMS to each contact
    SMSService->>CreditService: Deduct SMS count from user credit
    CreditService-->>SMSService: Confirm deduction

    SMSService-->>BackgroundJobService: SMS sent to all contacts
    BackgroundJobService-->>CampaignService: Background job completed
