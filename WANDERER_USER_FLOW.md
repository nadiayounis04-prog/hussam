# WANDERER USER FLOW

## FLOW SEQUENCE
1. **Chamber Landing** → 2. **Breaker Page** → 3. **Payment Gateway** → 4. **Stage Quiz** → 5. **Results** → 6. **Rituals**

## ENTRY POINTS
- `/chambers` - Main chambers page
- `/chamber/wanderer` - Direct wanderer chamber access

## STEP-BY-STEP BREAKDOWN

### 1. CHAMBER LANDING (`/chamber/wanderer`)
**Content:**
- Title: "🧭 WANDERER"
- Description: "Flux Node - The Anchorless Trap"
- Loop: "Constant movement, avoiding commitment, fear of settling."
- Needs: "Find anchor, commit to place, burn the need to wander."
- Rituals list (6 items)

**Navigation:**
- **Next:** "THE ANCHOR" button → `/chamber/wanderer/breaker`

### 2. BREAKER PAGE (`/chamber/wanderer/breaker`)
**Content:**
- Title: "THE ANCHOR"
- Subtitle: "Wanderer → The Anchor (Compass/Anchor Boss)"
- Regular Wanderer description
- Anchor (Future Self) description
- Visual elements with cyan/blue color scheme
- 🧭 compass emoji

**Navigation:**
- **Next:** "Begin the Anchor's Rite" button → `/chamber/wanderer/the-path`
- **Back:** "← Back to Wanderer Chamber" → `/chamber/wanderer`

### 3. PAYMENT GATEWAY (`/chamber/wanderer/the-path`)
**Content:**
- Title: "THE PATH"
- Subtitle: "Wanderer Node — Path to the Anchor"
- Early Stage description
- **Wanderer-specific payment section:**
  - "WANDERER — The Toll of Anchoring"
  - "You Are the Compass That Guides Lost Souls Home"
  - Motivational text about becoming the anchor
  - Visual section with 🧭 compass
  - Payment: $27
  - "Cross the Gate — $27" button

**Navigation:**
- **Next:** "Cross the Gate — $27" button → `/chamber/wanderer/breaker/the-path/field-proof/free-walk`
- **Back:** "← Back to Wanderer Chamber" → `/chamber/wanderer`

### 4. STAGE QUIZ (`/chamber/wanderer/breaker/the-path/field-proof/free-walk`)
**Content:**
- Title: "WANDERER NODE - Stage/Masks Diagnostic Quiz"
- 12 questions across 3 stages:
  - **Nomad Stage** (q1-q4): Constant movement, avoiding commitment
  - **Explorer Stage** (q5-q8): Purposeful exploration, still struggling with commitment
  - **Anchor Stage** (q9-q12): Found destination, can commit deeply
- Each question has 4 options (1-4 scale)
- Progress tracking
- Submit button

**Navigation:**
- **Next:** Submit quiz → `/chamber/wanderer/breaker/the-path/field-proof/free-walk/results`
- **Back:** Browser back → `/chamber/wanderer/the-path`

### 5. RESULTS (`/chamber/wanderer/breaker/the-path/field-proof/free-walk/results`)
**Content:**
- Quiz results display
- Current stage identification
- Mask identification
- Stage scores breakdown
- Diagnosis based on current stage + mask combination
- Personalized explanation and directive

**Navigation:**
- **Next:** "View Recommended Rituals" button → `/chamber/wanderer/rituals`
- **Back:** Browser back → `/chamber/wanderer/breaker/the-path/field-proof/free-walk`

### 6. RITUALS (`/chamber/wanderer/rituals`)
**Content:**
- Title: "Recommended Rituals for Wanderer"
- 6 archetype-specific rituals:
  1. Anchor Ritual (commit to one place)
  2. Opposite Day (act in commitment, not wandering)
  3. Mirror Burn (see the wanderer)
  4. Silent Meal (be present in one place)
  5. Death Ritual (kill the need to wander)
  6. Shadow Gift (integrate the settled self)
- Ritual descriptions and instructions
- Progress tracking

**Navigation:**
- **Back:** "← Back to Wanderer Chamber" → `/chamber/wanderer`

## IMPLEMENTATION STATUS

### ✅ COMPLETED
1. **Wanderer Archetype File** - Created `hussamallah/lib/archetypes/wanderer.ts` with complete stages, quiz questions, and diagnosis logic
2. **Archetype Registration** - Added wanderer to `hussamallah/lib/archetypes/index.ts`
3. **Chamber Landing** - Updated `/chamber/[archetype]/page.tsx` with wanderer-specific content:
   - "THE ANCHOR" title instead of "FUTURE SELF"
   - 🧭 compass emoji
   - Wanderer-specific description
   - "Begin the Anchor's Rite" button text
4. **Breaker Page** - Updated `/chamber/[archetype]/breaker/page.tsx` with wanderer support:
   - Added `isWanderer` variable
   - 🧭 compass emoji in button
   - "Begin the Anchor's Rite" button text
   - Wanderer-specific final message
5. **Payment Gateway** - Updated `/chamber/[archetype]/the-path/page.tsx` with wanderer-specific payment section:
   - "WANDERER — The Toll of Anchoring" section
   - Wanderer-specific motivational content
   - Cyan/blue color scheme
   - $27 payment with "Cross the Gate — $27" button
   - Redirects to `/chamber/wanderer/breaker/the-path/field-proof/free-walk`
6. **Configuration Updates** - Updated wanderer config subtitle to "Path to the Anchor"

### 🔄 EXISTING COMPONENTS (No Changes Needed)
1. **Stage Quiz** - `/chamber/[archetype]/breaker/the-path/field-proof/free-walk/page.tsx` already handles archetype-specific quiz data via `getArchetype()` function
2. **Results Page** - `/chamber/[archetype]/breaker/the-path/field-proof/free-walk/results/page.tsx` already handles archetype-specific results via `scoreQuiz()` function
3. **Rituals Page** - `/chamber/[archetype]/rituals/page.tsx` already contains wanderer-specific ritual content

### 🎯 KEY FEATURES IMPLEMENTED
- **Complete User Flow**: Chamber Landing → Breaker Page → Payment Gateway → Stage Quiz → Results → Rituals
- **Wanderer-Specific Content**: All pages now display wanderer-appropriate titles, descriptions, and navigation
- **Payment Integration**: Dedicated payment section with wanderer-themed content and $27 fee
- **Quiz Integration**: 12-question diagnostic quiz across 3 stages (Nomad, Explorer, Anchor)
- **Results Integration**: Personalized diagnosis based on current stage and mask
- **Rituals Integration**: 6 wanderer-specific rituals for transformation
- **Visual Consistency**: Cyan/blue color scheme with 🧭 compass emoji throughout
- **Navigation Flow**: Seamless progression through all 6 steps with proper back navigation

### 🚀 READY FOR TESTING
The complete Wanderer user flow is now implemented and ready for testing. Users can:
1. Navigate to `/chamber/wanderer`
2. Click "THE ANCHOR" to go to the breaker page
3. Click "Begin the Anchor's Rite" to access the payment gateway
4. Pay $27 to access the stage quiz
5. Complete the 12-question diagnostic
6. View personalized results and diagnosis
7. Access recommended rituals for transformation

The flow follows the exact same pattern as the Rebel archetype but with wanderer-specific content, themes, and messaging focused on finding one's anchor and guiding others home. 