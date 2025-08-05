# SERVANT USER FLOW

## Complete Journey Map for Servant Archetype

### 🚀 **ENTRY POINTS**
1. **Main Chambers Page** → `/chambers`
2. **Direct Servant Chamber** → `/chamber/servant`

---

### 📍 **STEP 1: Servant Chamber Landing**
**URL:** `/chamber/servant`
- **Content:** Servant archetype overview, description, and characteristics
- **Action:** User learns about being a Servant
- **Next:** User clicks "The Path" or "Breaker" button

---

### ⚡ **STEP 2: Breaker Page**
**URL:** `/chamber/servant/breaker`
- **Content:**
  - "THE SILENT REFUSAL"
  - Mythic language about becoming the Silent Refusal
  - Field signs and silent refusal's law
  - 5-minute read with powerful motivation
- **Action:** User clicks "Begin the Silent Refusal's Rite"
- **Next:** Redirects to Payment Gateway

---

### 🛤️ **STEP 3: The Path (Payment Gateway)**
**URL:** `/chamber/servant/the-path`
- **Content:** 
  - "SERVANT — The Toll of Submission"
  - Payment gateway with $27 fee
  - Motivational content about becoming the vessel
  - Benefits of taking the stage test
- **Action:** User clicks "Cross the Gate — $27"
- **Next:** Redirects to Stage Quiz

---

### 🧠 **STEP 4: Stage Quiz (20 Questions)**
**URL:** `/chamber/servant/breaker/the-path/field-proof/free-walk`
- **Content:**
  - "SERVANT NODE - Stage/Masks Diagnostic Quiz"
  - 20 questions to determine exact stage and mask
  - Progress bar showing completion
  - Servant-themed emerald/green styling
- **Action:** User answers all 20 questions
- **Next:** Results page with diagnosis

---

### 📊 **STEP 5: Quiz Results**
**URL:** `/chamber/servant/breaker/the-path/field-proof/free-walk/results`
- **Content:**
  - Stage diagnosis (Helper, Caregiver, Support Giver, Vessel, Silent Refusal)
  - Mask identification
  - Stage progress bars for all 5 stages
  - "Your True Need" section
  - **Single Action Button:** "Recommended Rituals"
- **Action:** User clicks "Recommended Rituals"
- **Next:** Rituals page

---

### 🔮 **STEP 6: Recommended Rituals**
**URL:** `/chamber/servant/rituals`
- **Content:**
  - Stage-specific rituals for progression
  - Practices to move from current stage to next
  - Ritual library with 30+ advanced practices
  - Servant-specific ritual descriptions
- **Action:** User practices rituals to evolve
- **Next:** User can retake quiz to measure progress

---

## 🔄 **ALTERNATIVE FLOWS**

### **Flow A: Standard Journey**
```
Chamber → Breaker → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow B: Direct Path (Alternative)**
```
Chamber → The Path → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow C: Retake Quiz**
```
Results → Stage Quiz → New Results → Rituals
```

---

## 🎯 **KEY FEATURES**

### **Payment Integration**
- **$27 fee** for stage quiz access
- **Payment gateway** with motivational content
- **Seamless redirect** to quiz after payment

### **Stage Detection**
- **5 stages:** Helper → Caregiver → Support Giver → Vessel → Silent Refusal
- **Mask identification** for each stage
- **Progress tracking** across all stages
- **Personalized diagnosis** with specific needs

### **Ritual System**
- **Stage-specific practices** for progression
- **Advanced ritual library** with 30+ practices
- **Targeted evolution** from current to next stage

### **User Experience**
- **Beautiful UI** with emerald/green servant theme
- **Responsive design** for all devices
- **Smooth navigation** between pages
- **Clear call-to-actions** at each step

---

## 📱 **MOBILE EXPERIENCE**
- **Responsive buttons** that stack on mobile
- **Readable text** at all screen sizes
- **Touch-friendly** quiz interface
- **Smooth animations** optimized for mobile

---

## 🎨 **VISUAL THEME**
- **Primary Colors:** Emerald (#059669) and Green (#10b981)
- **Background:** Black with subtle gradients
- **Animations:** Pulse effects, glowing borders
- **Typography:** Bold, mystical, motivational

---

## 🔧 **TECHNICAL IMPLEMENTATION**
- **Next.js routing** with dynamic archetype parameters
- **React state management** for quiz progress
- **URL parameters** for quiz results sharing
- **Conditional rendering** for servant-specific content
- **Responsive CSS** with Tailwind

---

## 📈 **CONVERSION OPTIMIZATION**
- **Clear value proposition** at payment gateway
- **Single action button** on results page
- **Motivational language** throughout journey
- **Progress visualization** to show advancement
- **Personalized recommendations** based on results

---

## 🎯 **SUCCESS METRICS**
- **Payment conversion** from gateway to quiz
- **Quiz completion rate** (20 questions)
- **Ritual engagement** after results
- **Return visits** for progress tracking
- **Stage progression** over time

---

## 🧤 **SERVANT-SPECIFIC CONTENT**

### **Payment Gateway Content:**
- **Title:** "SERVANT — The Toll of Submission"
- **Main Message:** "You Are the Vessel That Reality Cannot Resist"
- **Visual:** Glove emoji (🧤) with vessel energy
- **Investment:** $27 as toll for becoming the vessel
- **Benefits:** Vessel rituals and submission practices
- **CTA:** "Become the Vessel — $27"

### **Stage Progression:**
1. **Helper** - Basic helping and support
2. **Caregiver** - Emotional support and care
3. **Support Giver** - Active support provision
4. **Vessel** - Becoming a vessel for others' giving
5. **Silent Refusal** - The vessel that reality cannot resist

---

*This flow creates a complete, engaging journey for Servant users to discover their stage, understand their mask, and access targeted rituals for evolution.* 